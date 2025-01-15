using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Inventario
{
    public class Producto
    {
        private int idProducto;
        private int idCategoria;
        private string nombre;
        private string unidadMedida;
        private int stock;
        private int stockMinimo;
        private decimal precioCompra;
        private decimal precioVenta;

        public Producto()
        {
        }

        public Producto(int idproducto, int idcategoria, string producto_nombre, string producto_unidadMedida, int producto_stock, int producto_stockMinimo, decimal producto_precioCompra, decimal producto_precioVenta)
        {
            this.idProducto = idproducto;
            this.idCategoria = idcategoria;
            this.nombre = producto_nombre;
            this.unidadMedida = producto_unidadMedida;
            this.stock = producto_stock;
            this.stockMinimo = producto_stockMinimo;
            this.precioCompra = producto_precioCompra;
            this.precioVenta = producto_precioVenta;
        }

        public int Idproducto { get => idProducto; set => idProducto = value; }
        public int Idcategoria { get => idCategoria; set => idCategoria = value; }
        public string Producto_nombre { get => nombre; set => nombre = value; }
        public string Producto_unidadMedida { get => unidadMedida; set => unidadMedida = value; }
        public int Producto_stock { get => stock; set => stock = value; }
        public int Producto_stockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public decimal Producto_precioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal Producto_precioVenta { get => precioVenta; set => precioVenta = value; }
    }
}
