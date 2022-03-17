using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Models
{
    public class Desarrolladora
    {
        public int DesarrolladoraId { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        public string Pagina { get; set; }
        public string UserId { get; set; }
        public  ApplicationUser User { get; set; }
    }
}
