using Datos;
using Datos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class CategoriaLN
    {
        public List<Entidades.Inventario.Categoria> ViewCategoria()
        {
            List<Entidades.Inventario.Categoria> lista = new List<Entidades.Inventario.Categoria>();
            Entidades.Inventario.Categoria oc;
            try
            {
                List<Datos.Categoria> auxLista = CategoriaCD.listarCategoria();
                foreach (Datos.Categoria obj in auxLista)
                {
                    oc = new Entidades.Inventario.Categoria(obj.IdCategoria, obj.Nombre, obj.Descripcion);
                    lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostar categoria de la tabla de BD", ex);
            }
            finally
            {

            }
            return lista;
        }
        public List<Entidades.Inventario.Categoria> ViewCategoriaFiltro(string valor)
        {
            List<Entidades.Inventario.Categoria> lista = new List<Entidades.Inventario.Categoria>();
            Entidades.Inventario.Categoria oc;

            try
            {
                List<CP_ListarCategoriasFiltroResult> auxLista = CategoriaCD.listarCategoriaFiltro(valor);
                foreach (CP_ListarCategoriasFiltroResult obj in auxLista)
                {
                    oc = new Entidades.Inventario.Categoria(obj.IdCategoria, obj.Nombre, obj.Descripcion);
                    lista.Add(oc);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostar categoria con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }




    }
}
