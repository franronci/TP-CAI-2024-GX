using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using Persistencia.Utils;

namespace Negocio
{
    public abstract class ProductoNegocio
    {
        public ProductoWS producto = new ProductoWS();
        public string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<DatosProductoWS> listarProductos()
        {
            return producto.getProductos();
        }

        public void AgregarProductos(int idCategoria, string idUsuario, string idProveedor, string Nombre, int Precio, int Stock)
        {
            AltaProducto altaProducto = new AltaProducto(idCategoria, idUsuario, idProveedor, Nombre, Precio, Stock);
            producto.AgregarProducto(altaProducto);
        }

        public void ModificarProducto(string idProducto, string idUsuario, int Precio, int Stock)
        {
            producto.ModificarProducto(idProducto, idUsuario, Precio, Stock);

        }

        public void BorrarProducto(string idProducto)
        {
            producto.bajaProducto(idProducto);
        }
    }
}