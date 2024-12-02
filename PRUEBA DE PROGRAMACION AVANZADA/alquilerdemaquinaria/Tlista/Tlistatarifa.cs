using alquilerdemaquinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alquilerdemaquinaria.Tlista
{
    public class Tlistatarifa
    {
        public static List<tarifa> ListaDetarifa = new List<tarifa>();

        public static void Agregartarifas()
        {
            tarifa so = new tarifa("C01", "Proyectores", 50);
            ListaDetarifa.Add(so);
            so = new tarifa("C02", "Impresoras láser", 30);
            ListaDetarifa.Add(so);
            so = new tarifa("C03", "Computadoras portátiles", 70);
            ListaDetarifa.Add(so);
        }

        public static void agregar(tarifa ta)
        {
            ListaDetarifa.Add(ta);
        }

        public static int Buscar(string ced)
        {
            int pos = -1;
            for (int i = 0; i < ListaDetarifa.Count; i++)
            {
                if (ListaDetarifa[i].Codigo.Equals(ced))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static tarifa getSocio(int pos)
        {
            return ListaDetarifa[pos];
        }

        public static void rellenarcombobox(ComboBox combo)
        {
            for (int i = 0; i < ListaDetarifa.Count; i++)
            {
                combo.Items.Add(ListaDetarifa[i].Codigo);
            }
        }

    }
}
