using JavierSanchezProyectoCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavierSanchezProyectoCore.ViewModels
{
    public class IndexJuegosViewModel
    {
        public int? id { get; set; }

        public List<Juego> Juegos { get; set; }

        public string filtroTitulo { get; set; }

        public Genero filtroGenero { get; set; }
        public SelectList GeneroList { get; set; }
    }
}
