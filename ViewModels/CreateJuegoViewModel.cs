using JavierSanchezProyectoCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class CreateJuegoViewModel
    {
        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de salida es obligatoria")]
        public DateTime Salida { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public decimal Precio { get; set; }
        public IFormFile Caratula { get; set; }
        public decimal? Descuento { get; set; }
        public Uri TrailerURL { get; set; }
        public string Genero { get; set; }
        public List<string> Generos { get; set; }
        
    }
}
