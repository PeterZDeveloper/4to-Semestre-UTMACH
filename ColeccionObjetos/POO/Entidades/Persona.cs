using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Entidades
{
    public class Persona
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        private char sexo;
        private string estado;
        private string tipoSangre;
        private string ciudad;
        public Persona()
        {
        }

        public Persona(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string estado, string tipoSangre, string ciudad)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.Estado = estado;
            this.TipoSangre = tipoSangre;
            this.Ciudad = ciudad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
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
        public string SignoZodiacal()
        {
            int dia;
            int mes;
            string signo = "";
            dia = fechaNacimiento.Day;
            mes = fechaNacimiento.Month;
            switch (mes)
            {
                case 1:
                    if (dia > 21)
                    {
                        signo = "ACUARIO";
                    }
                    else
                    {
                        signo = "CAPRICORNIO";
                    }
                    break;
                case 2:
                    if (dia > 19)
                    {
                        signo = "PISCIS";
                    }
                    else
                    {
                        signo = "ACUARIO";
                    }
                    break;
                case 3:
                    if (dia > 20)
                    {
                        signo = "ARIES";
                    }
                    else
                    {
                        signo = "PISCIS";
                    }
                    break;
                case 4:
                    if (dia > 20)
                    {
                        signo = "TAURO";
                    }
                    else
                    {
                        signo = "ARIES";
                    }
                    break;
                case 5:
                    if (dia > 21)
                    {
                        signo = "GEMINIS";
                    }
                    else
                    {
                        signo = "TAURO";
                    }
                    break;
                case 6:
                    if (dia > 20)
                    {
                        signo = "CANCER";
                    }
                    else
                    {
                        signo = "GEMINIS";
                    }
                    break;
                case 7:
                    if (dia > 22)
                    {
                        signo = "LEO";
                    }
                    else
                    {
                        signo = "CANCER";
                    }
                    break;
                case 8:
                    if (dia > 21)
                    {
                        signo = "VIRGO";
                    }
                    else
                    {
                        signo = "LEO";
                    }
                    break;
                case 9:
                    if (dia > 22)
                    {
                        signo = "LIBRA";
                    }
                    else
                    {
                        signo = "VIRGO";
                    }
                    break;
                case 10:
                    if (dia > 22)
                    {
                        signo = "ESCORPION";
                    }
                    else
                    {
                        signo = "LIBRA";
                    }
                    break;
                case 11:
                    if (dia > 21)
                    {
                        signo = "SAGITARIO";
                    }
                    else
                    {
                        signo = "ESCORPION";
                    }
                    break;
                case 12:
                    if (dia > 21)
                    {
                        signo = "CAPRICORNIO";
                    }
                    else
                    {
                        signo = "SAGITARIO";
                    }
                    break;

            }
            return signo;
        }
    }
}
