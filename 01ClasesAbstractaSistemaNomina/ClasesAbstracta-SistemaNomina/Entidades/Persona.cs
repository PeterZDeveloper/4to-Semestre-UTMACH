using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstracta_SistemaNomina.Entidades
{
    public abstract class Persona
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        private char sexo;
        private string tipo;

        private double sueldo;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        protected Persona(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string tipo, double sueldo)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.tipo = tipo;
            this.sueldo = sueldo;
        }

        public double Bonos()
        {
            double bono = 0;  
            if (this.SiCumpleaños())
            {
                bono += 100;
            }

            if (this.Edad() > 60)
            {
                bono += 50;
            }

            return bono;
        }

        public int Edad()
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaNacimiento > fechaActual)
            {
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }
        public bool SiCumpleaños()
        {
            DateTime fechaActual = DateTime.Today;

            return fechaNacimiento.Month == fechaActual.Month && fechaNacimiento.Day == fechaActual.Day;
        }

        public abstract double CalcularSueldo();

        public String GenSTRING()
        {
            return $"Cedula {cedula} \nNombres {nombres} \nApellidos {apellidos} \nFecha Nacimiento{fechaNacimiento} \nSexo{sexo} \ntipo{tipo}";
        }

        public abstract void imprimir();




    }
}
