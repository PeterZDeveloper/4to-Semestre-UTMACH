using alquilerdemaquinaria.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alquilerdemaquinaria.Tlista
{
    public class TlistaDevolucion
    {
        public static List<Devolucion> listaAlquiler = new List<Devolucion>();

        public static void insertar(Devolucion al)
        {
            listaAlquiler.Add(al);
        }



        public static int Buscar(string ced)
        {
            int pos = -1;
            for (int i = 0; i < listaAlquiler.Count; i++)
            {
                if (listaAlquiler[i].Al.Socio.Id.Equals(ced))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Devolucion getPersona(int pos)
        {
            return listaAlquiler[pos];
        }

        public static void agregadomaximo (DataGridView oc)
        {
            var sql = from le in listaAlquiler
                      group le by le.Al.Tarifa.Tipo into t
                      select new { Tipo = t.Key, sum = t.Max(p => p.Al.Pagototal) };



            oc.DataSource = sql.ToList();
        }
        public static void agregadopromedio(DataGridView oc)
        {
            var sql = from le in listaAlquiler
                      group le by le.Al.Tarifa.Tipo into t
                      select new { Tipo = t.Key, sum = t.Average(p => p.Al.Pagototal) };



            oc.DataSource = sql.ToList();
        }
    }
}
