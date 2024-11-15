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
    public class Producto
    {
        public ProductoWS producto = new ProductoWS();
        public string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<DatosProductoWS> listarProductos()
        {
            return producto.getProductos();
        }

        public void AgregarProductos(int idCategoria, string idUsuario, string idProveedor, string Nombre, double Precio, int Stock)
        {
            AltaProducto altaProducto = new AltaProducto(idCategoria, idUsuario, idProveedor, Nombre, Precio, Stock);
            producto.AgregarProducto(altaProducto);
        }

        public void ModificarProducto(string idProducto, string idUsuario, double Precio, int Stock)
        {
            producto.ModificarProducto(idProducto, idUsuario, Precio, Stock);

        }

        public void BorrarProducto(string idProducto)
        {
            producto.bajaProducto(idProducto);
        }

        public Dictionary<int, List<DatosProductoWS>> ObtenerProductosPorCategoriaConStockBajo(int stockLimite)
        {
            ProductoWS productoWS = new ProductoWS();
            List<DatosProductoWS> listaProductos = productoWS.getProductos();

            Dictionary<int, List<DatosProductoWS>> productosPorCategoria = new Dictionary<int, List<DatosProductoWS>>();

            foreach (var producto in listaProductos)
            {
                if (producto.Stock < stockLimite)
                {
                    if (!productosPorCategoria.ContainsKey(producto.IdCategoria))
                    {
                        productosPorCategoria[producto.IdCategoria] = new List<DatosProductoWS>();
                    }

                    productosPorCategoria[producto.IdCategoria].Add(producto);
                }
            }

            return productosPorCategoria;
        }



    }
}