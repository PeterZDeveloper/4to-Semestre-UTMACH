using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstracta_SistemaNomina.Entidades
{
    public class Comisionado : Comision
    {
        private double salario;
        public Comisionado(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string tipo, double sueldo, double vent, double porcentaje, double sal) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, tipo, sueldo, vent, porcentaje)
        {
            this.salario = sal;
            this.Sueldo = CalcularSueldo();
        }

        public double Salario { get => salario; set => salario = value; }

        public override double CalcularSueldo()
        {
            double total;
            double bono;
            bono = Bonos();
            total = salario + (Ventas * (Porcentaje / 100));
            return total +bono;
        }
        public override void imprimir()
        {
            MessageBox.Show(this.GenSTRING() + $"\nVentas: {Ventas}\nPorcentaje: {Porcentaje}\nSalario{Salario}\nSueldo {this.Sueldo}");
        }
    }
}
