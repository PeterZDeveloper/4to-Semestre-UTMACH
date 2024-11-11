using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_ClasesAbstractas_Nomina.Entidades
{
    public class Comisionados : Persona
    {
        public double SalarioBase { get; set; }     // Salario fijo del trabajador
        public double TarifaComision { get; set; }  // Porcentaje de comisión
        public double VentasBrutas { get; set; }    // Monto de ventas realizadas

        public Comisionados() { }

        public Comisionados(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string estado, string tipo, string ciudad, double sal, double tarifac, double ventasb)
    : base(cedula, nombres, apellidos, fechaNacimiento, sexo, estado, tipo, ciudad)
        {
            this.SalarioBase = sal;
            this.TarifaComision = tarifac;
            this.VentasBrutas = ventasb;
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
            double comision = VentasBrutas * TarifaComision;
            return (SalarioBase * 1.1 + comision) + BonificacionAntiguedad(); // Agrega 10% al salario base
        }


        public override void Imprimir()
        {
            MessageBox.Show("Cedula: " + Cedula + "\n"
                            + "Nombre: " + Nombres + "\n"
                            + "Tipo: " + Tipo + "\n"
                            + "Tarifa de Comision: " + TarifaComision + "\n"
                            + "Ventas Brutas: " + VentasBrutas + "\n"
                            + "Sueldo: " + CalcularSueldo());
        }
    }
}
