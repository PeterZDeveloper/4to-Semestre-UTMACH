using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClasesAbstracta_SistemaNomina.Entidades
{
    public class Fijo:Persona
    {
        private double salario;
        private double iees;
        private double anticipo;

        public Fijo(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string tipo, double sueldo,double sal,double ies,double ant) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, tipo, sueldo)
        {
            this.salario = sal;
            this.iees = ies;
            this.anticipo = ant; 
            this.Sueldo = CalcularSueldo();
        }

        public double Salario { get => salario; set => salario = value; }
        public double Iees { get => iees; set => iees = value; }
        public double Anticipo { get => anticipo; set => anticipo = value; }

        public override double CalcularSueldo()
        {
            double total;
            double bono;
            double PieEs = (salario * iees) / 100;
            total = salario - (PieEs + anticipo);
            bono =Bonos();
            return total+bono;
        }

        public override void imprimir()
        {
            MessageBox.Show(this.GenSTRING()+$"\nSalario: { salario}\nIEES: { iees}\nAnticipo: { anticipo} \nSueldo {this.Sueldo}");
        }
    }
}
