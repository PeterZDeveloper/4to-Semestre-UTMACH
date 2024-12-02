using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerdemaquinaria.Entidades
{
    public class Alquiler
    {
        private int id;
        private Socio socio;
        private tarifa tarifa;
        private DateTime fechaEntrega;
        private DateTime fechaTentativa;
        private int dias;
        private double importe;
        private double descuentoduracion;
        private double descuentocliente;
        private double deposito;
        private double pagototal = 0;
   

        public Alquiler(int id, Socio socio, tarifa tarifa, DateTime fechaEntrega, DateTime fechaTentativa)
        {
            this.id = id;
            this.socio = socio;
            this.tarifa = tarifa;
            this.fechaEntrega = fechaEntrega;
            this.fechaTentativa = fechaTentativa;
            this.dias = calculardias();
            this.importe = calcularimporte();
            this.descuentoduracion = descuentosdias();
            this.descuentocliente = descuentossocio();
            this.deposito = Deposito();
            this.pagototal = this.importe-this.descuentoduracion-this.descuentocliente;
        }

        public int Id { get => id; set => id = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public tarifa Tarifa { get => tarifa; set => tarifa = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaTentativa { get => fechaTentativa; set => fechaTentativa = value; }
        public int Dias { get => dias; set => dias = value; }
        public double Importe { get => importe; set => importe = value; }
        public double Descuentoduracion { get => descuentoduracion; set => descuentoduracion = value; }
        public double Descuentocliente { get => descuentocliente; set => descuentocliente = value; }
        public double Deposito1 { get => deposito; set => deposito = value; }
        public double Pagototal { get => pagototal; set => pagototal = value; }


        public int calculardias()
        {
            int dias = FechaTentativa.Day - fechaEntrega.Day;

            return dias;
        }

        public double calcularimporte()
        {
            double importe = Tarifa.Tarifadia * calculardias();
            return importe;
        }

        public double descuentossocio()
        {
            double descuento = 0;

            if (Socio.ContratoAfilacion.Equals("Activo"))
            {
                descuento = calcularimporte() * 0.10;
            }

            return descuento;
        }

        public double descuentosdias()
        {
            double descuento = 0;

            if (calculardias() > 7)
            {
                descuento = calcularimporte() * 0.20;
            }

            return descuento;
        }


        public double Deposito()
        {
            double Deposito = pagototal * 0.15;


            return Deposito;
        }


    }
}
