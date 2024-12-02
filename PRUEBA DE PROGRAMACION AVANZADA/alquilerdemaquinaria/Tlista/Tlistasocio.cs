using alquilerdemaquinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alquilerdemaquinaria.Tlista
{
    public class Tlistasocio
    {

        public static List<Socio> ListaDeSocios= new List<Socio>();

        public static void AgregarSocios()
        {
            Socio so = new Socio(1,"Activo");
            ListaDeSocios.Add(so);
            so= new Socio(2,"Negativo");
            ListaDeSocios.Add(so);
            so = new Socio(3, "Activo");
            ListaDeSocios.Add(so);
        }

        public static int Buscar(int ced)
        {
            int pos = -1;
            for (int i = 0; i < ListaDeSocios.Count; i++)
            {
                if (ListaDeSocios[i].Id==ced)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        public static Socio getSocio(int pos)
        {
            return ListaDeSocios[pos];
        }

        public static void rellenarcombobox(ComboBox combo)
        {
            for (int i = 0; i < ListaDeSocios.Count; i++)
            {
                combo.Items.Add(ListaDeSocios[i].Id);
            }
        }

    }
}
