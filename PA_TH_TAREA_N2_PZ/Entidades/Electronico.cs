using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_TH_TAREA_N2_PZ
{
    public class Electronico
    {
        public string Codigo { get; set; } 
        public double Costo { get; set; }
        public double Descuento { get; set; }
        public double Incremento { get; set; }
        public double IGV { get; set; }
        public string Tipo { get; set; }
        public double Total { get; set; }


        public Electronico() { }

        public Electronico(string codigo, double costo, double descuento, double incremento, double iGV, string tipo, double total)
        {
            Codigo = codigo;
            Costo = costo;
            Descuento = descuento;
            Incremento = incremento;
            IGV = iGV;
            Tipo = tipo;
            Total = total;
        }
    }
}
