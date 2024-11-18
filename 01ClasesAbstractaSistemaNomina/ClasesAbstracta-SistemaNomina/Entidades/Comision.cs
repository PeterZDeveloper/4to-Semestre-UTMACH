using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstracta_SistemaNomina.Entidades
{
    public class Comision: Persona
    {
        private double ventas;
        private double porcentaje;

        public Comision(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string tipo, double sueldo,double vent,double porcentaje) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, tipo, sueldo)
        {
            this.ventas = vent;
            this.porcentaje = porcentaje;
            this.Sueldo = CalcularSueldo();
            this.Bonos();
        }

        public double Ventas { get => ventas; set => ventas = value; }
        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        public override double CalcularSueldo()
        {
            double total;
            double bono;
            bono = Bonos();
            total = ventas *(porcentaje / 100);
            return total +bono ;
        }

        public override void imprimir()
        {
            MessageBox.Show(this.GenSTRING() + $"\nVentas: {ventas}\nPorcentaje: {porcentaje}\nSueldo {this.Sueldo}");
        }
    }
}
