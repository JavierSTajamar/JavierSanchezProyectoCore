
using JavierSanchezProyectoCore.Data;
using JavierSanchezProyectoCore.Extensions;
using JavierSanchezProyectoCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Controllers
{
    public class VentaController : Controller
    {
        private readonly ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        public VentaController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Cliente")]
        public IActionResult AddCarrito(int? id)
        {
            if (id != null)
            {
                List<int> carrito;
                if (HttpContext.Session.GetObject<List<int>>("CARRITO") == null)
                {
                    carrito = new List<int>();
                }
                else
                {
                    carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
                }
                if (carrito.Contains(id.Value) == false)
                {
                    carrito.Add(id.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }
            }
            
            return RedirectToAction("Index","Juego");
        }
        [Authorize(Roles = "Cliente")]
        public async Task<IActionResult> Carrito(int? id)
        {
            List<int> carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
            if (carrito == null)
            {
                
                return View();
            }
            else
            {
                if (id!=null)
                {
                    carrito.Remove(id.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }
            }
            List<Juego> juegos = await _db.Juegos.Where(j => carrito.Contains(j.JuegoId)).ToListAsync();
            return View(juegos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Cliente")]
        public async Task<IActionResult> Carrito()
        {
            List<int> juegosId = HttpContext.Session.GetObject<List<int>>("CARRITO");
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);
            Venta venta = new Venta();
            venta.FechaVenta = DateTime.Now;
            venta.Cliente = await _db.Clientes.Where(c => c.User.Id == currentUserId).FirstOrDefaultAsync();
            _db.Add(venta);
            await _db.SaveChangesAsync();

            var rand = new Random();
            decimal total=0;
            foreach (int id in juegosId)
            {
                var key = rand.Next(10000)+"";
                for (int i = 0; i < 3; i++)
                {
                    key = key + "-" + rand.Next(10000) ;
                }
                Juego juego = _db.Juegos.Find(id);
                DetalleVenta detalleVenta = new DetalleVenta();
                detalleVenta.Juego = juego;
                detalleVenta.Key = key;
                if (juego.Descuento!=0)
                {
                    detalleVenta.Precio = (decimal)(juego.Precio - (juego.Precio * juego.Descuento / 100));
                }
                else
                {
                    detalleVenta.Precio = juego.Precio;
                }
                total = total + detalleVenta.Precio;
                detalleVenta.VentaId = venta.VentaId;
                
                _db.Add(detalleVenta);
            }
            
            venta.PrecioTotal = (double)total;
            _db.Update(venta);
            await _db.SaveChangesAsync();
            HttpContext.Session.Remove("CARRITO");
            return RedirectToAction("Details", "Cliente", new { id=venta.ClienteId});
        }
        
    }
}
