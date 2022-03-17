using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nickname { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
