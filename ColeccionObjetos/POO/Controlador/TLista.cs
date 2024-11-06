using POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Controlador
{
    public class TLista
    {
        public static List<Persona> Lista = new List<Persona>();
        public static void Insertar(Persona op)
        {
            Lista.Add(op);
        }
        public static void Modificar(int pos, Persona op)
        {
            Lista[pos] = op;
        }
        public static void Eliminar(int pos)
        {
            Lista.RemoveAt(pos);
        }

        public static int Buscar(string ced)
        {
            int pos = -1;
            for(int i=0;i<Lista.Count;i++)
            {
                if (Lista[i].Cedula.Equals(ced))
                {
                    pos= i;
                    break;
                }
            }
            return pos;
        }

        public static Persona getPersona(int pos)
        {
            return Lista[pos];
        }

        //usamos LINQ
        public static int CantidadMayoresEdad()
        {
            return Lista.Count(p => p.Edad() >= 18);
        }

        public static int CantidadMenoresEdad()
        {
            return Lista.Count(p => p.Edad() < 18);
        }

        public static double PorcentajeMayoresEdad()
        {
            if (Lista.Count == 0)
                return 0;

            int mayores = CantidadMayoresEdad();
            return (double)mayores / Lista.Count * 100;
        }

        public static double PorcentajeMenoresEdad()
        {
            if (Lista.Count == 0)
                return 0;

            int menores = Lista.Count - CantidadMayoresEdad();
            return (double)menores / Lista.Count * 100;
        }

    }
}
