using Identity.School.App.ViewModels;
using JavierSanchezProyectoCore.Data;
using JavierSanchezProyectoCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = vm.Email,
                    Email = vm.Email,
                    
                };
                string Role = vm.Role;
                var result = await _userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Role);
                    await _signInManager.SignInAsync(user, false);
                    if (Role.Equals("Desarrolladora"))
                    {
                        return RedirectToAction("Create", "Desarrolladora");
                    }
                    else
                    {
                        return RedirectToAction("Create", "Cliente");
                    }
                    
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.
                    PasswordSignInAsync(vm.Email, vm.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(vm.Email);
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains("Desarrolladora"))
                    {
                        Desarrolladora desarrolladora = await _db.Desarrolladoras.Where(d=>d.User==user).FirstOrDefaultAsync();
                        return RedirectToAction("Details","Desarrolladora", new { id = desarrolladora.DesarrolladoraId });
                    }
                    else if (roles.Contains("Cliente"))
                    {
                        Cliente cliente = await _db.Clientes.Where(d => d.User == user).FirstOrDefaultAsync();
                        return RedirectToAction("Details", "Cliente", new { id = cliente.ClienteId });
                    }
                    return RedirectToAction("Index", "Juego");

                }
                ModelState.AddModelError("", "Login Failure");
            }
            return View(vm);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Juego");
        }

    }
}
