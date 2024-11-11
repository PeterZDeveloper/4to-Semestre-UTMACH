using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_A_ClasesAbstractas_Nomina.Controlador
{
    public class TLista<T>
    {
        public static List<T> Lista = new List<T>();
        //Metodo Insertar
        public static void Insertar(T item)
        {
            Lista.Add(item);
        }
        //Metodo Mofificar
        public static void Modificar(int pos, T item)
        {
            Lista[pos] = item;
        }
        //Metodo Eliminar
        public static void Eliminar(int pos)
        {
            Lista.RemoveAt(pos);
        }
        //Metodo booleano de busqueda
        public static int Buscar(Func<T, bool> criterio)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (criterio(Lista[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        // Método de búsqueda para propiedades de tipo string
        public static int BuscarPorString(Func<T, string> selector, string valorBuscado)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (selector(Lista[i]) == valorBuscado)
                {
                    return i;
                }
            }
            return -1;
        }

        // Método de búsqueda para propiedades de tipo double
        public static int BuscarPorDouble(Func<T, double> selector, double valorBuscado)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (selector(Lista[i]) == valorBuscado)
                {
                    return i;
                }
            }
            return -1;
        }

        // Método de búsqueda para propiedades de tipo int
        public static int BuscarPorInt(Func<T, int> selector, int valorBuscado)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (selector(Lista[i]) == valorBuscado)
                {
                    return i;
                }
            }
            return -1;
        }


        public static T GetItem(int pos)
        {
            return Lista[pos];
        }

        // Método que devuelve la lista de elementos
        public static List<T> Listar()
        {
            return new List<T>(Lista); // Devuelve una copia de la lista
        }
    }
}
