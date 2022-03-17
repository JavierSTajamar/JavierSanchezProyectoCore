using JavierSanchezProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class DetailsClienteViewModel
    {
        public List<DetalleVenta> Ventas { get; set; }

        public Cliente Cliente { get; set; }
    }
}
