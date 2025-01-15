using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class ProductoCD
    {
        public static List<Producto> listarProducto()
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar la tabla producto", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static List<CP_ListarProductosFiltroResult> listarProductoFiltro(string val)
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.CP_ListarProductosFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar producto filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarProducto(Entidades.Inventario.Producto op)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_InsertarProductos(op.Idproducto, op.Idcategoria, op.Producto_nombre, op.Producto_unidadMedida, op.Producto_stock, op.Producto_stockMinimo, op.Producto_precioCompra, op.Producto_precioVenta);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla producto", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarProducto(Entidades.Inventario.Producto op)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_ModificarProducto(op.Idproducto, op.Idcategoria, op.Producto_nombre, op.Producto_unidadMedida, op.Producto_stock, op.Producto_stockMinimo, op.Producto_precioCompra, op.Producto_precioVenta);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al modificar tabla producto", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarProducto(Entidades.Inventario.Producto op)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_EliminarProducto(op.Idproducto);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar tabla producto", ex);
            }
            finally
            {
                DB = null;
            }
        }
    }
}
