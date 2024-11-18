using ClasesAbstracta_SistemaNomina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstracta_SistemaNomina.Contralador
{
    public class TlistaPersona
    {
        public static List<Persona> lista = new List<Persona>();
        public static void Insertar(Persona op)
        {
            lista.Add(op);
        }
        public static void Modificar(int pos, Persona op)
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

        public static Persona getPersona(int pos)
        {
            return lista[pos];
        }

        public static List<Persona> ListarTiposEmpleados(string tipo)
        {
            var sql = from le in TlistaPersona.lista
                where le.Tipo.Equals(tipo)
                select le;
            return sql.ToList();
        }

    }
}
