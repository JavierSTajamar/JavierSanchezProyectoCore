using JavierSanchezProyectoCore.Data;
using JavierSanchezProyectoCore.Models;
using JavierSanchezProyectoCore.ViewModels;
using Microsoft.AspNetCore.Http;
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
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        public ClienteController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // GET: ClienteController
        public async Task<IActionResult> Index()
        {
            var clientes = await _db.Clientes.Include(x=>x.User).ToListAsync();
            return View(clientes);
        }
        public async Task<IActionResult> DetailsUser(string name)
        {
            Cliente cliente = await _db.Clientes.Include(x => x.User).Where(x => x.User.Email == name).FirstOrDefaultAsync();


            return RedirectToAction("Details", new { id = cliente.ClienteId });
        }
        public async Task<IActionResult> Tienda(string name)
        {
            Cliente cliente = await _db.Clientes.Include(x => x.User).Where(x => x.User.Email == name).FirstOrDefaultAsync();


            return RedirectToAction("Index","Juego", new { id = cliente.ClienteId });
        }

        // GET: ClienteController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);
            Cliente cliente = await _db.Clientes.Where(c => c.User.Id == currentUserId).FirstOrDefaultAsync();
            DetailsClienteViewModel vm = new DetailsClienteViewModel();
            vm.Cliente = cliente;
            vm.Ventas = await _db.DetalleVentas.Include(v => v.Venta).Include(j => j.Juego).Include(c => c.Venta.Cliente).Where(c => c.Venta.ClienteId == cliente.ClienteId).ToListAsync();
            return View(vm);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente c)
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);
            if (ModelState.IsValid)
            {
                Cliente cliente = new Cliente();
                cliente.Nickname = c.Nickname;
                cliente.Nombre = c.Nombre;
                cliente.Apellidos = c.Apellidos;
                cliente.User = user;
                _db.Add(cliente);
                await _db.SaveChangesAsync();
                return RedirectToAction("Details", new { id = cliente.ClienteId });
            }
            return View();
        }

        // GET: ClienteController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Cliente cliente = await _db.Clientes.FindAsync(id);
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cliente cliente)
        {
            _db.Update(cliente);
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", new { id = cliente.ClienteId });
        }

    }
}
