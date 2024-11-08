using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_TH_TAREA_N2_PZ
{
    public class Pelicula
    {


        public Pelicula()
        {
        }

        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public double Duracion { get; set; }
        public string Actor { get; set; }

        public Pelicula(string titulo, string categoria, double duracion, string actor)
        {
            Titulo = titulo;
            Categoria = categoria;
            Duracion = duracion;
            Actor = actor;
        }
    }
}
