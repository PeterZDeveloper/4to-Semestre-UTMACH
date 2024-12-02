using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_PrestamoLibros.Entidades
{
    public class Prestamo
    {
        private string cedulaEstudiante;
        private string nombreEstudiante;
        private string codigoLibro;
        private string nombreLibro;
        private DateTime fechaPrestamo;
        private DateTime fechaEntrega;
        private bool devuelto = false;

        public Prestamo(string cedulaEstudiante, string nombreEstudiante, string codigoLibro, string nombreLibro, DateTime fechaPrestamo, DateTime fechaEntrega, bool devuelto)
        {
            this.CedulaEstudiante = cedulaEstudiante;
            this.NombreEstudiante = nombreEstudiante;
            this.NombreLibro = nombreLibro;
            this.CodigoLibro = codigoLibro;
            this.FechaPrestamo = fechaPrestamo;
            this.FechaEntrega = fechaEntrega;
            this.Devuelto = devuelto;
        }

        public string CedulaEstudiante { get => cedulaEstudiante; set => cedulaEstudiante = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public string CodigoLibro { get => codigoLibro; set => codigoLibro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public bool Devuelto { get => devuelto; set => devuelto = value; }

        //private Libro lib;
        // public Estudiante ESTU { get => ESTU; set => ESTU = value; }

        // public Libro LIB { get => lib; set => lib = value; }






    }

}
