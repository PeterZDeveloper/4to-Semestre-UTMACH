using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientadoAObjetos.Entidades
{
    public class Consultor:Persona
    {
        private double horas;
        private double costo;

        public Consultor()
    : base()
        {

        }

        public Consultor(string ced, string nom, string ape, DateTime fecha, char sex, string est, double hor, double cos)
    : base(ced, nom, ape, fecha, sex, est)
        {
            this.horas = hor;
            this.costo = cos;
        }

        public double CalcularSueldo()
        {
            return horas*costo;
        }

        public void Imprimir()
        {
            MessageBox.Show(base.ImprimirPersona() + " \n" +
                "Horas: " + horas + " \n" +
                "Costo: " + costo + " \n" +
                "Total a cobrar: " + CalcularSueldo());
        }


    }
}
