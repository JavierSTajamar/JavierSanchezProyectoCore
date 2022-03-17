using JavierSanchezProyectoCore.Data;
using JavierSanchezProyectoCore.Models;
using JavierSanchezProyectoCore.ViewModels;
using Microsoft.AspNetCore.Hosting;
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
    public class DesarrolladoraController : Controller
    {

        private readonly ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        public DesarrolladoraController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // GET: DesarrolladoraController
        public async Task<IActionResult> Index()
        {
            var desarrolladoras = await _db.Desarrolladoras.ToListAsync();
            return View(desarrolladoras);
        }
        public async Task<IActionResult> DetailsUser(string name)
        {
            Desarrolladora desarrolladora = await _db.Desarrolladoras.Include(x => x.User).Where(x => x.User.Email == name).FirstOrDefaultAsync();
           

            return RedirectToAction("Details",new { id=desarrolladora.DesarrolladoraId});
        }
        // GET: DesarrolladoraController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Desarrolladora desarrolladora = await _db.Desarrolladoras.Include(x => x.User).Where(x => x.DesarrolladoraId == id).FirstOrDefaultAsync();
            var juegos = await _db.Juegos.Where(j => j.DesarrolladoraId == id).Include(j=>j.GenerosJuego).ToListAsync();
            foreach (var juego in juegos)
            {
                foreach (var item in juego.GenerosJuego)
                {
                    item.Genero = await _db.Generos.FindAsync(item.GeneroId);
                }
            }
            DetailsDesarrolladoraViewModel vm = new DetailsDesarrolladoraViewModel();
            vm.Juegos = juegos;
            vm.desarrolladora = desarrolladora;
            
            return View(vm);
        }

        // GET: DesarrolladoraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DesarrolladoraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateDesarrolladoraViewModel vm)
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);
            if (ModelState.IsValid)
            {
                var nombreImagen = "defaultLogo.png";
                if (vm.ImagenLogo != null)
                {
                    string ficheroImagenes = "wwwroot/images";
                    nombreImagen = vm.Nombre + Path.GetExtension(vm.ImagenLogo.FileName);
                    string rutaDefinitiva = ficheroImagenes + "/" + nombreImagen;
                    vm.ImagenLogo.CopyTo(new FileStream(rutaDefinitiva, FileMode.Create));
                }
                Desarrolladora desarrolladora = new Desarrolladora();
                desarrolladora.Nombre = vm.Nombre;
                desarrolladora.Logo = nombreImagen;
                desarrolladora.Pagina = vm.Pagina;
                desarrolladora.User = user;
                _db.Add(desarrolladora);
                await _db.SaveChangesAsync();
                return RedirectToAction("Details", "Desarrolladora", new { id = desarrolladora.DesarrolladoraId });
            }
            return View();

        }

        // GET: DesarrolladoraController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            EditDesarrolladoraViewModel vm = new EditDesarrolladoraViewModel();
            var desarrolladora = await _db.Desarrolladoras.FindAsync(id);
            vm.DesarrolladoraId = desarrolladora.DesarrolladoraId;
            vm.Nombre = desarrolladora.Nombre;
            
            vm.Pagina = desarrolladora.Pagina;
            
            return View(vm);
        }

        // POST: DesarrolladoraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditDesarrolladoraViewModel vm)
        {
            Desarrolladora desarrolladora = await _db.Desarrolladoras.FindAsync(id);
            var nombreImagen = desarrolladora.Logo;
            if (vm.ImagenLogo != null)
            {

                string ficheroImagenes = "wwwroot/images/";
                nombreImagen = vm.Nombre + Path.GetExtension(vm.ImagenLogo.FileName);
                string rutaDefinitiva = ficheroImagenes + nombreImagen;
                vm.ImagenLogo.CopyTo(new FileStream(rutaDefinitiva, FileMode.Create));
            }
            desarrolladora.Nombre = vm.Nombre;
            desarrolladora.Logo = nombreImagen;
            desarrolladora.Pagina = vm.Pagina;
            _db.Update(desarrolladora);
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", new { id = desarrolladora.DesarrolladoraId });
        }

              
       
    }
}
