using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Models
{
    public class GeneroJuego
    {
        public int GeneroJuegoId { get; set; }
        public int GeneroId { get; set; }
        public int JuegoId { get; set; }
        public virtual Juego Juego { get; set; }
        public virtual Genero Genero { get; set; }

       
    }
}
