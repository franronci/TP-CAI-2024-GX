using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int traerStockProducto(string producto, int categoria)
        {

            ProductoWS productoWS = new ProductoWS();

            List<DatosProductoWS> datosProductoWs = productoWS.getProductosByCategoria(categoria);

            foreach (var producto_lista in datosProductoWs)
            {

                if (producto_lista.Nombre == producto)
                {
                    return producto_lista.Stock;
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


        public Guid traerIDproducto(string nombre, int categoria)
        {
            ProductoWS productoWS = new ProductoWS();

            List<DatosProductoWS> lista_productos = productoWS.getProductosByCategoria(categoria);

            foreach (var producto in lista_productos)
            {
                if(producto.Nombre == nombre)
                {
                    return producto.Id;
                }
            }

            return Guid.Empty;
        }


        public bool hayVentaCliente(int dni)
        {
            
            Guid id_cliente = traerIDcliente(dni);

            VentaWS venta = new VentaWS();

            List<VentaPorCliente> lista_venta_cliente = venta.GetVentasCliente(id_cliente);

            return lista_venta_cliente.Count == 0;
        }

        public Guid traerIDcliente(int dni)
        {
            ClienteWS clienteWS = new ClienteWS();

            
            List<DatosClienteWS> lista_clientes = clienteWS.getClientes();

            
            foreach (var cliente in lista_clientes)
            {
                if (cliente.DNI == dni) 
                {
                    return cliente.Id; 
                }
            }

            return Guid.Empty;
        }

        
        public string traerNombreCliente(int dni)
        {
            ClienteWS clienteWS = new ClienteWS();

           
            List<DatosClienteWS> lista_clientes = clienteWS.getClientes();

           
            foreach (var cliente in lista_clientes)
            {
                if (cliente.DNI == dni) 
                {
                    return cliente.Nombre; 
                }
            }

            return ""; 
        }

        
        public string traerApellidoCliente(int dni)
        {
            ClienteWS clienteWS = new ClienteWS();

            
            List<DatosClienteWS> lista_clientes = clienteWS.getClientes();

            
            foreach (var cliente in lista_clientes)
            {
                if (cliente.DNI == dni) 
                {
                    return cliente.Apellido; 
                }
            }

            return "";
        }

        
        public string traerEmailCliente(int dni)
        {
            ClienteWS clienteWS = new ClienteWS();

            
            List<DatosClienteWS> lista_clientes = clienteWS.getClientes();

            
            foreach (var cliente in lista_clientes)
            {
                if (cliente.DNI == dni) 
                {
                    return cliente.Email; 
                }
            }

            return ""; 
        }

        public void AgregarVentaNegocio(AltaVenta agregarVenta)
        {
            VentaWS ventasWS = new VentaWS();
            ventasWS.AgregarVenta(agregarVenta);
        }


    }
}
