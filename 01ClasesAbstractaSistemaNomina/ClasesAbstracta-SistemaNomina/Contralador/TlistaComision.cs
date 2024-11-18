using ClasesAbstracta_SistemaNomina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstracta_SistemaNomina.Contralador
{
    public class TlistaComision
    {
        public static List<Comision> lista = new List<Comision>();
        public static void Insertar(Comision op)
        {
            lista.Add(op);
        }
        public static void Modificar(int pos, Comision op)
        {
            lista[pos] = op;
        }
        public static void Eliminar(int pos)
        {
            lista.RemoveAt(pos);
        }
        public static int Buscar(string ced)
        {
            int pos = -1;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Cedula.Equals(ced))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Comision getComision(int pos)
        {
            return lista[pos];
        }
        public static void ClearLista()
        {
            lista.Clear();
        }
    }
}
