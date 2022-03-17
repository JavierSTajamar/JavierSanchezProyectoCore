using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class CreateDesarrolladoraViewModel
    {
       
        public string Nombre { get; set; }
        public IFormFile ImagenLogo { get; set; }
        public string Pagina { get; set; }
    }
}
