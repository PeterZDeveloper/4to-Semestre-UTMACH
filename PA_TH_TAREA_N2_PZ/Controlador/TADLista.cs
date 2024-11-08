using System;
using System.Collections.Generic;

namespace PA_TH_TAREA_N2_PZ
{
    public class TLista<T>
    {
        public static List<T> Lista = new List<T>();

        public static void Insertar(T item)
        {
            Lista.Add(item);
        }

        public static void Modificar(int pos, T item)
        {
            Lista[pos] = item;
        }

        public static void Eliminar(int pos)
        {
            Lista.RemoveAt(pos);
        }

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
