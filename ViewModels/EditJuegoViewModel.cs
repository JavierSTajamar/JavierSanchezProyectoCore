using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class EditJuegoViewModel
    {
        public int JuegoId { get; set; }
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
        public string stringCatarula { get; set; }
        public decimal? Descuento { get; set; }
        public Uri TrailerURL { get; set; }
    }
}
