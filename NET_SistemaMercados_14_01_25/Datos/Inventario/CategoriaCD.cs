using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Inventario
{
    public class CategoriaCD
    {
        public static List<Categoria> listarCategoria()
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.Categoria.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar la tabla categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static List<CP_ListarCategoriasFiltroResult> listarCategoriaFiltro(string val)
        {
            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    return DB.CP_ListarCategoriasFiltro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar categoria filtro", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void InsertarCategoria(Entidades.Inventario.Categoria oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_InsertarCategoria(oc.IdCategoria, oc.Nombre, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void ModificarCategoria(Entidades.Inventario.Categoria oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_ModificarCategoria(oc.IdCategoria, oc.Nombre, oc.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al modificar tabla categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }
        public static void EliminarCategoria(Entidades.Inventario.Categoria oc)
        {

            BDMarketDataContext DB = null;
            try
            {

                using (DB = new BDMarketDataContext())
                {
                    DB.CP_EliminarCategoria(oc.IdCategoria);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar tabla categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }




    }
}
