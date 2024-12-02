using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_PrestamoLibros.Entidades
{
    public class Libro
    {
        /*
- Código de Libro/revista
- Categoria del libro/revista
- Editorial
- Nombre del Libro
- Autor
Año de publicación
         */
        private string CodigoLibro;
        private string Tipo;
        private string Categoria;
        private string Editorial;
        private string NombreLibro;
        private string Autor;
        private int AnioPublicacion;
        private bool Disponible;

        public string CodigoLibro1 { get => CodigoLibro; set => CodigoLibro = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
        public string NombreLibro1 { get => NombreLibro; set => NombreLibro = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public int AnioPublicacion1 { get => AnioPublicacion; set => AnioPublicacion = value; }
        public bool Disponible1 { get => Disponible; set => Disponible = value; }

        public Libro()
        {
        }

        public Libro(string codigoLibro, string tipo, string categoria, string editorial, string nombreLibro, string autor, int anioPublicacion, bool disponible)
        {
            CodigoLibro1 = codigoLibro;
            Tipo1 = tipo;
            Categoria1 = categoria;
            Editorial1 = editorial;
            NombreLibro1 = nombreLibro;
            Autor1 = autor;
            AnioPublicacion = anioPublicacion;
            Disponible1 = true;
        }

        public void MarcarPrestado()
        {
            Disponible1 = false;
        }

        public void MarcarDisponible()
        {
            Disponible1 = true;
        }

        public int ObtenerAnioDeFecha(DateTime fechaSeleccionada)
        {
            return fechaSeleccionada.Year;
        }

    }
}
