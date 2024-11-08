using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PA_TH_TAREA_N2_PZ
{
    public class Alumno
    {
        public Alumno()
        {
        }

        public string nombre { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double promedio { get; set; }
        public string turno { get; set; }

        public double buenas { get; set; }
        public double malas { get; set; }

        public Alumno(string nombre, double nota1, double nota2, double nota3, double promedio, string turno)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.promedio = promedio;
            this.turno = turno;
        }

        public Alumno(string nombre, double buenas, double malas)
        {
            this.nombre = nombre;
            this.buenas = buenas;
            this.malas = malas;
        }
    }
}
