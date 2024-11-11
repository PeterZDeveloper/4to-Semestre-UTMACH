using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_A_ClasesAbstractas_Nomina
{
    public abstract class Persona
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        private char sexo;
        private string estado;
        private string tipo;
        private string ciudad;


        public Persona()
        {
        }

        public Persona(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string estado, string tipo, string ciudad)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.Estado = estado;
            this.Tipo = tipo;
            this.Ciudad = ciudad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }



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
        public string EdadCompleta()
        {

            DateTime fechaActual = DateTime.Now;
            int años = fechaActual.Year - fechaNacimiento.Year;
            int meses = fechaActual.Month - fechaNacimiento.Month;
            int dias = fechaActual.Day - fechaNacimiento.Day;
            if (meses < 0)
            {
                años--;
                meses += 12;
            }
            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(fechaNacimiento.Year, fechaNacimiento.Month);
            }
            return años + "-" + meses + "-" + dias;
        }

        public abstract double CalcularSueldo();

        public abstract double BonificacionAntiguedad();

        public abstract void Imprimir();
            

    }
}
