using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_TH_TAREA_N2_PZ
{
    public class Postulantes
    {
        public string Nombre { get; set; } //metodo mas rapido para inicializar vaoles y poner getters y setters,
        public double Aciertos { get; set; }
        public double Fallos { get; set; }
        public double Puntaje { get; set; }

        //Constructor vacio.
        public Postulantes() { }

        // Constructor para inicializar los datos del postulante
        public Postulantes(string nombre, double aciertos, double fallos, double puntaje)
        {
            Nombre = nombre;
            Aciertos = aciertos;
            Fallos = fallos;
            Puntaje = puntaje;
        }
    }
}
