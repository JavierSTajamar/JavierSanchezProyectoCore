using JavierSanchezProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class DetailsDesarrolladoraViewModel
    {
        public Desarrolladora desarrolladora { get; set; }
        public ICollection<Juego> Juegos { get; set; }
    }
}
