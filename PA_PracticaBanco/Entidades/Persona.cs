using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_PracticaBanco.Entidades
{
    public abstract class Persona
    {
        private string cedula;
        private string nombre;
        private string direccion;
        private string telefono;
        private int edad;


        public Persona()
        {

        }

        protected Persona(string cedula, string nombre, string direccion, string telefono, int edad)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.edad = edad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }

        public abstract void Imprimir();
    }
}
