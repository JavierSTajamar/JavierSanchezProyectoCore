using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.Models
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public decimal Precio { get; set; }
        public string Key { get; set; }
        public int VentaId { get; set; }
        public int JuegoId { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual Juego Juego { get; set; }
    }
}
