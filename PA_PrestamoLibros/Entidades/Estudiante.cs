using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_PrestamoLibros.Entidades
{
    public class Estudiante
    {
        private string Cedula;
        private string Nombre;
        private string Apellido;
        public string Sexo;
        public DateTime FechaNacimiento;
        private DateTime FechaFinSancion;
        private bool Sancionado;

        public Estudiante()
        {
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public DateTime FechaFinSancion1 { get => FechaFinSancion; set => FechaFinSancion = value; }
        public bool Sancionado1 { get => Sancionado; set => Sancionado = value; }

        public Estudiante(string cedula, string nombre, string apellido, string sexo, DateTime fechaNacimiento, DateTime fechaFinSancion, bool sancionado)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            FechaFinSancion = fechaFinSancion;
            Sancionado = sancionado;
        }

        public void Sancionar(DateTime fechaFin)
        {
            Sancionado1 = true;
            FechaFinSancion1 = fechaFin;
        }
        public void LevantarSancion()
        {
            Sancionado = false;
            FechaFinSancion = DateTime.MinValue; // Restablece a sin sanción
        }

    }
}
