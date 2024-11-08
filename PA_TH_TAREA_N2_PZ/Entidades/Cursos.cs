using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_TH_TAREA_N2_PZ
{
    public class Cursos
    {
        public Cursos()
        {
        }

        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public double NCursos { get; set; }
        public string Fpago { get; set; }
        public double Descuento { get; set; }
        public double Incremento { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }

        public Cursos(string nombre, double nCursos, string fpago, double descuento, double incremento, double subTotal, double total)
        {
            Nombre = nombre;
            NCursos = nCursos;
            Fpago = fpago;
            Descuento = descuento;
            Incremento = incremento;
            SubTotal = subTotal;
            Total = total;
        }

        public Cursos(string nombre, string tipo, double nCursos, string fpago, double descuento, double incremento, double subTotal, double total)
        {
            Nombre = nombre;
            Tipo = tipo;
            NCursos = nCursos;
            Fpago = fpago;
            Descuento = descuento;
            Incremento = incremento;
            SubTotal = subTotal;
            Total = total;
        }

        public Cursos(string nombre, string tipo, double nCursos, string fpago, double subTotal, double total)
        {
            Nombre = nombre;
            Tipo = tipo;
            NCursos = nCursos;
            Fpago = fpago;
            SubTotal = subTotal;
            Total = total;
        }
    }
}
