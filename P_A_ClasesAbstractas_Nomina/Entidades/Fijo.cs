using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_ClasesAbstractas_Nomina
{
    internal class Fijo:Persona
    {
        private double salario;
        private double ies;
        private double anticipo;

        public Fijo()
        {
        }

        public Fijo(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string estado, string tipo, string ciudad, double sal, double ies, double anti) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, estado, tipo, ciudad)
        {
            this.salario = sal;
            this.ies = ies;
            this.anticipo = anti;
        }

        public double Salario { get => salario; set => salario = value; }
        public double Ies { get => ies; set => ies = value; }
        public double Anticipo { get => anticipo; set => anticipo = value; }


        public override double BonificacionAntiguedad()
        {
            int edad = Edad(); // Usa el método Edad() de Persona para obtener la edad del empleado

            // Si la edad es 60 o mayor, calculamos la bonificación. Si no, devolvemos 0.
            if (edad >= 60)
            {
                return (edad - 60) * 50 + 50; // $50 por cada año después de los 60, más $50 para el primer año (60).
            }
            else
            {
                return 0; // Si tiene menos de 60 años, no tiene bonificación.
            }
        }


        public override double CalcularSueldo()
        {
            return (salario - ies - anticipo) + BonificacionAntiguedad();
        }


        public override void Imprimir()
        {
            MessageBox.Show("Cedula: " + Cedula + "\n"
                            + "Nombre: " + Nombres + "\n"
                            + "Tipo: " + Tipo + "\n"
                            + "Salario: " + salario + "\n"
                            + "Iess: " + ies + "\n"
                            + "Anticipo: " + anticipo + "\n"
                            + "Sueldo: " + CalcularSueldo());
              
        }
    }
}
