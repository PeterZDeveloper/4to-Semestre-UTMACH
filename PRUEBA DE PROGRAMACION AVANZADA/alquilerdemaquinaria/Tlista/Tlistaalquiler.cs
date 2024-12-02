using alquilerdemaquinaria.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerdemaquinaria.Tlista
{
    public class Tlistaalquiler
    {

        public static List<Alquiler> listaAlquiler=new List<Alquiler>();

        public static void insertar(Alquiler al)
        {
            listaAlquiler.Add(al);
        }

        public static void eliminar(int posicion)
        {
            listaAlquiler.RemoveAt(posicion);
        }

        public static void editar(Alquiler al, int posicion)
        {
            listaAlquiler[posicion] = al;
        }

        public static int Buscar(int ced)
        {
            int pos = -1;
            for (int i = 0; i < listaAlquiler.Count; i++)
            {
                if (listaAlquiler[i].Id==ced)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Alquiler getPersona(int pos)
        {
            return listaAlquiler[pos];
        }

    }
}
