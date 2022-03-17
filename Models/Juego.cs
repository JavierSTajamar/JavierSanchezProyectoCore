using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Models
{
    
    public class Juego
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
        public string Caratula { get; set; }
        public decimal? Descuento { get; set; }
        public string TrailerURL { get; set; }
        public int DesarrolladoraId { get; set; }
        public virtual Desarrolladora Desarrolladora { get; set; }
        public virtual ICollection<GeneroJuego> GenerosJuego { get; set; }
    }
}
