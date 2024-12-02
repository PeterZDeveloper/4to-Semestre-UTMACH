using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerdemaquinaria.Entidades
{
    public class Devolucion
    {
        private Alquiler al;
        private DateTime fechadevolucion;
        private double multa = 0;

        public Devolucion(Alquiler al, DateTime fechadevolucion)
        {
            this.al = al;
            this.fechadevolucion = fechadevolucion;
            this.multa = Multa();
            verificarfechaentrega();
        }

        public Alquiler Al { get => al; set => al = value; }
        public DateTime Fechadevolucion { get => fechadevolucion; set => fechadevolucion = value; }
        public double Multa1 { get => multa; set => multa = value; }

        public void verificarfechaentrega()
        {
            if (al.FechaTentativa < fechadevolucion)
            {
                if (al.Deposito() < Multa())
                {
                    multa -= al.Deposito1;
                    al.Deposito1 = 0;
                }
            }

        }

        public double Multa()
        {
            int dias = fechadevolucion.Day - al.FechaTentativa.Day;
            double multa = al.Tarifa.Tarifadia * dias;
            return multa;
        }
    }
}
