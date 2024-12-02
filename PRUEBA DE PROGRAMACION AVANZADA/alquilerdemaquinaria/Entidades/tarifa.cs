using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerdemaquinaria.Entidades
{
    public class tarifa
    {
        private String codigo;
        private String tipo;
        private double tarifadia;

      
        public tarifa(string codigo, string tipo, double tarifadia)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.tarifadia = tarifadia;
        }

        public tarifa()
        {
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Tarifadia { get => tarifadia; set => tarifadia = value; }


    }
}
