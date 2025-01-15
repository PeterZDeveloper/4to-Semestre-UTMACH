using Datos.Inventario;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Inventario
{
    public class ProductoLN
    {
        public List<Entidades.Inventario.Producto> ViewProducto()
        {
            List<Entidades.Inventario.Producto> lista = new List<Entidades.Inventario.Producto>();
            Entidades.Inventario.Producto op;
            try
            {
                List<Datos.Producto> auxLista = ProductoCD.listarProducto();
                foreach (Datos.Producto obj in auxLista)
                {
                    op = new Entidades.Inventario.Producto(obj.Idproducto,obj.Idcategoria,obj.Producto_nombre,obj.Producto_unidadMedida,obj.Producto_stock,obj.Producto_stockMinimo,obj.Producto_precioCompra,obj.Producto_precioVenta);
                    lista.Add(op);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostar producto de la tabla de BD", ex);
            }
            finally
            {

            }
            return lista;
        }
        public List<Entidades.Inventario.Producto> ViewProductoFiltro(string valor)
        {
            List<Entidades.Inventario.Producto> lista = new List<Entidades.Inventario.Producto>();
            Entidades.Inventario.Producto op;

            try
            {
                List<CP_ListarProductosFiltroResult> auxLista = ProductoCD.listarProductoFiltro(valor);
                foreach (CP_ListarProductosFiltroResult obj in auxLista)
                {
                    op = new Entidades.Inventario.Producto(obj.Idproducto,obj.Idcategoria, obj.Producto_nombre, obj.Producto_unidadMedida,obj.Producto_stock,obj.Producto_stockMinimo,obj.Producto_precioCompra,obj.Producto_precioVenta);
                    lista.Add(op);
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
