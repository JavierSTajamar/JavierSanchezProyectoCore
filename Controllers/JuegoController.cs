using JavierSanchezProyectoCore.Data;
using JavierSanchezProyectoCore.Models;
using JavierSanchezProyectoCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Controllers
{
    public class JuegoController : Controller
    {
        private readonly ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        public JuegoController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int? id)
        {
            var juegos = await _db.Juegos.Include(j => j.GenerosJuego).ToListAsync();
            if (id != null)
            {

                var juegosCliente = await _db.DetalleVentas.Include(v => v.Venta).Include(j => j.Juego).Include(c => c.Venta.Cliente).Where(c => c.Venta.ClienteId == id).Select(c => c.Juego).ToListAsync();
                juegos = juegos.Except(juegosCliente).ToList();
            }

            foreach (var juego in juegos)
            {
                foreach (var item in juego.GenerosJuego)
                {
                    item.Genero = await _db.Generos.FindAsync(item.GeneroId);
                }
            }
            var generoDisplay = await _db.Generos.Select(x => new { Id = x.GeneroId, Value = x.Nombre }).ToListAsync();
            IndexJuegosViewModel vm = new IndexJuegosViewModel();
            vm.Juegos = juegos;
            vm.GeneroList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(generoDisplay, "Id", "Value");
            vm.id = id;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(IndexJuegosViewModel vm)
        {
            var juegos = await _db.Juegos.Include(j => j.GenerosJuego).ToListAsync();
            
            if (vm.filtroGenero.GeneroId != 0)
            {

                juegos = await _db.GenerosJuegos.Where(j => j.Genero.GeneroId == vm.filtroGenero.GeneroId).Select(j => j.Juego).ToListAsync();
                
            }
            if (vm.filtroTitulo != null)
            {
                juegos = juegos.Where(j => j.Titulo.Contains(vm.filtroTitulo)).ToList();
            }
            if ( vm.id != null)
            {

                var juegosCliente = await _db.DetalleVentas.Include(v => v.Venta).Include(j => j.Juego).Include(c => c.Venta.Cliente).Where(c => c.Venta.ClienteId == vm.id).Select(c => c.Juego).ToListAsync();
                juegos = juegos.Except(juegosCliente).ToList();
            }

            foreach (var juego in juegos)
            {
                foreach (var item in juego.GenerosJuego)
                {
                    item.Genero = await _db.Generos.FindAsync(item.GeneroId);
                }
            }

            var generoDisplay = await _db.Generos.Select(x => new { Id = x.GeneroId, Value = x.Nombre }).ToListAsync();
            vm.Juegos = juegos;
            vm.GeneroList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(generoDisplay, "Id", "Value");
            return View(vm);
        }
        public async Task<IActionResult> Details(int id, bool? disabled)
        {
            Juego juego = await _db.Juegos.Where(j => j.JuegoId == id).Include(j => j.GenerosJuego).Include(j => j.Desarrolladora).SingleOrDefaultAsync();
            foreach (var item in juego.GenerosJuego)
            {
                item.Genero = await _db.Generos.FindAsync(item.GeneroId);
            }
            if (disabled != null)
            {
                ViewBag.Disabled = disabled;
            }
            else
            {
                ViewBag.Disabled = false;
            }


            return View(juego);
        }

        // GET: JuegoController/Create
        public async Task<IActionResult> Create()
        {
            var generos = await _db.Generos.ToListAsync();
            ViewBag.Generos = new SelectList(generos, "GeneroId", "Nombre");
            return View();
        }

        // POST: JuegoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateJuegoViewModel vm)
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);
            if (ModelState.IsValid)
            {
                var nombreImagen = "DefaultCaratula.png";
                if (vm.Caratula != null)
                {
                    string ficheroImagenes = "wwwroot/images";
                    nombreImagen = vm.Titulo + Path.GetExtension(vm.Caratula.FileName);
                    string rutaDefinitiva = ficheroImagenes + "/" + nombreImagen;
                    vm.Caratula.CopyTo(new FileStream(rutaDefinitiva, FileMode.Create));
                }
                Desarrolladora desarrolladora = await _db.Desarrolladoras.Where(d => d.User == user).FirstOrDefaultAsync();
                Juego juego = new Juego();
                juego.Titulo = vm.Titulo;
                juego.Descripcion = vm.Descripcion;
                juego.Salida = vm.Salida;
                juego.Precio = vm.Precio;
                juego.Caratula = nombreImagen;
                juego.Descuento = vm.Descuento;
                juego.TrailerURL = vm.TrailerURL.OriginalString.Split('/').Last();
                juego.Desarrolladora = desarrolladora;
                _db.Add(juego);
                foreach (var item in vm.Generos)
                {

                    GeneroJuego generoJuego = new GeneroJuego();
                    generoJuego.Genero = await _db.Generos.FindAsync(Int32.Parse(item));
                    generoJuego.Juego = juego;
                    _db.Add(generoJuego);
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Details", "Desarrolladora", new { id = desarrolladora.DesarrolladoraId });
            }
            return View();

        }
        // GET: JuegoController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            EditJuegoViewModel vm = new EditJuegoViewModel();
            var juego = await _db.Juegos.FindAsync(id);
            vm.JuegoId = juego.JuegoId;
            vm.Titulo = juego.Titulo;
            vm.Descripcion = juego.Descripcion;
            vm.Salida = juego.Salida;
            vm.Precio = juego.Precio;
            vm.Descuento = juego.Descuento;
            vm.TrailerURL = new Uri("https://www.youtube.com/embed/" + juego.TrailerURL);
            vm.stringCatarula = "wwwroot/images/" + juego.Caratula;
            return View(vm);
        }

        // POST: JuegoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditJuegoViewModel vm)
        {
            Juego juego = await _db.Juegos.FindAsync(id);
            var nombreImagen = juego.Caratula;
            if (vm.Caratula != null)
            {

                string ficheroImagenes = "wwwroot/images/";
                
                nombreImagen = vm.Titulo + Path.GetExtension(vm.Caratula.FileName);
                string rutaDefinitiva = ficheroImagenes + nombreImagen;
                vm.Caratula.CopyTo(new FileStream(rutaDefinitiva, FileMode.Create));
            }

            juego.Titulo = vm.Titulo;
            juego.Descripcion = vm.Descripcion;
            juego.Salida = vm.Salida;
            juego.Precio = vm.Precio;
            juego.Caratula = nombreImagen;
            juego.Descuento = vm.Descuento;
            juego.TrailerURL = vm.TrailerURL.OriginalString.Split('/').Last();

            _db.Update(juego);
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", "Desarrolladora", new { id = juego.DesarrolladoraId });
        }
        // GET: JuegoController/CreateGenero
        public IActionResult CreateGenero()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGenero(Genero genero)
        {
            _db.Add(genero);
            await _db.SaveChangesAsync();
            return RedirectToAction("Create");
        }

    }
}
