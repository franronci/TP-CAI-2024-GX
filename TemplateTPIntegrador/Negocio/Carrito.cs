using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Carrito
    {

        public double totalventaXproducto(string producto, int cantidad, int categoria)
        {

            double total = precioProducto(producto, categoria) * cantidad;

            return total;


        }



        public double precioProducto(string producto, int categoria)
        
        
        {
            ProductoWS productoWS = new ProductoWS();

            List<DatosProductoWS> datosProductoWs = productoWS.getProductosByCategoria(categoria);

            foreach (var producto_lista in datosProductoWs)
            {
             
                if (producto_lista.Nombre == producto)
                {
                    return producto_lista.Precio;
                }
            }

            return -1;

        }


        public List<string> traerNombreProductos(int categoria)
        {
            ProductoWS productoWS = new ProductoWS();

            List<DatosProductoWS> datosProductoWs = productoWS.getProductosByCategoria(categoria);

            List<string> nombresProductos = new List<string>();

            foreach (var producto in datosProductoWs)
            {
                nombresProductos.Add(producto.Nombre);
            }

            return nombresProductos;
        }

        public Guid traerID(string nombre)
        {
            ProductoWS productoWS = new ProductoWS();

            List<DatosProductoWS> lista_productos = productoWS.getProductos();

            foreach (var producto in lista_productos)
            {
                if(producto.Nombre == nombre)
                {
                    return producto.Id;
                }

            }

            return Guid.Empty;
        }



    }
}
