using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientadoAObjetos.Entidades
{
    public class Persona
    {
        private string cedula;
        private string nombres;
        private string apellido;
        private DateTime fechaNacimiento;
        private char sexo;
        private string estado;
        
        public Persona()
        {

        }


        public Persona(string cedula, string nombres, string apellido, DateTime fechaNacimiento, char sexo, string estado)
        {
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.Estado = estado;
        }
        //=> = lamda = que implica
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Estado { get => estado; set => estado = value; }

        public int Edad()
        {
     DateTime now = DateTime.Today;
                int edad = DateTime.Today.Year - fechaNacimiento.Year;

                if (DateTime.Today < fechaNacimiento.AddYears(edad))
                    return --edad;
                else
                    return edad;
      
        }

        public int EdadCompleta()
        {
            return 0;
        }

        public string ImprimirPersona()
        {
            return "Cedula: " + cedula +
                 "\n" +"Nombres: " + this.nombres +
                 "\n"+"Apellidos: " + this.apellido +
                 "\n"+"Sexo: " + sexo +
                 "\n"+"Estado: " + estado +
                 "\n"+"Edad: " +  Edad();
        }
    }
}
