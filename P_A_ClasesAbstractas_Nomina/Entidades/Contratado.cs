using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_ClasesAbstractas_Nomina.Entidades
{
    public class Contratado : Persona
    {

        private double hora;
        private double costo;
        private double ies;
        public Contratado()
        {
        }

        public Contratado(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string estado, string tipo, string ciudad, double hor, double cos, double ies) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, estado, tipo, ciudad)
        {
            this.hora = hor;
            this.costo = cos;  
            this.Ies = ies;
        }

        public double Hora { get => hora; set => hora = value; }
        public double Costo { get => costo; set => costo = value; }
        public double Ies { get => ies; set => ies = value; }

        public double CalcularIess()
        {
            double total = 0;
            if (hora > 160)
            { // Si las horas exceden 160, aplica el descuento
                total = ((hora * costo) * ies) / 100;
               // MessageBox.Show("Las horas trabajadas exceden 160. Se realizará un descuento con respecto al IESS.");
            }
            return total;
        }



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
            return (hora * costo - CalcularIess()) + BonificacionAntiguedad();
        }


        public override void Imprimir()
        {
            MessageBox.Show("Cedula: " + Cedula + "\n"
     + "Nombre: " + Nombres + "\n"
       + "Tipo: " + Tipo + "\n"
        + "Horas: " + hora + "\n"
         + "Costo: " + costo + "\n"
                             + "Ies: " + CalcularIess() + "\n"

          + "Sueldo : " + CalcularSueldo()
    );
        }
    }
}
