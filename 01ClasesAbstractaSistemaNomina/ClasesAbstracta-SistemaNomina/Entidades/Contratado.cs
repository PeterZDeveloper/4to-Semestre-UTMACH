using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesAbstracta_SistemaNomina.Entidades
{
    public class Contratado : Persona
    {
        private double hora;
        private double costo;
        private double iess;

        public Contratado(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, char sexo, string tipo, double sueldo, double hor,double cost, double iess) 
            : base(cedula, nombres, apellidos, fechaNacimiento, sexo, tipo, sueldo)
        {
            this.hora = hor;
            this.costo = cost;
            this.iess = iess;
            this.Sueldo = CalcularSueldo();
        }

        public double Hora { get => hora; set => hora = value; }
        public double Costo { get => costo; set => costo = value; }
        public double Iess { get => iess; set => iess = value; }

        public double CalcularIess()
        {
            double total = 0;
            if (hora > 160)
            {
                total = ((hora * costo) * iess) / 100;
            }
            return total;
        }

        public override double CalcularSueldo()
        {
            double bono;
            double total;
            bono = Bonos();
            total = (hora * costo) - CalcularIess();
            return total + bono;
        }

        public override void imprimir()
        {
            MessageBox.Show(this.GenSTRING() + $"\nHora: {hora}\nCosto: {costo}\nIees: {iess} \nSueldo {this.Sueldo}");
        }
    }
}
