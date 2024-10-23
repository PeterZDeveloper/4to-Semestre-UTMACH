using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientadoAObjetos.Entidades
{
    public class Fijo:Persona
    {
        private double sueldo;
        private double impuesto;
         //constructor vacio;
        public Fijo()
            :base()
        {

        }

        public Fijo(string ced, string nom, string ape, DateTime fecha, char sex, string est, double sue, double imp)
    : base(ced, nom, ape, fecha, sex, est)
        {
            this.sueldo = sue;
            this.impuesto = imp;
        }

        public double CalcularSueldo()
        {
            return sueldo - impuesto;
        }

        public void Imprimir()
        {
            MessageBox.Show(base.ImprimirPersona()+ " \n" +
                "Sueldo: "+ sueldo + " \n" +
                "Impuestos: " + impuesto + " \n" +
                "Total a cobrar: " + CalcularSueldo());
        }

    }
}
