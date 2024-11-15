using Datos;
using Persistencia;
using Persistencia.Utils;
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
                if (producto.Nombre == nombre)
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

            return lista_venta_cliente.Count > 0;
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

        public void AgregarVentaNegocio(AltaVenta agregarVenta, decimal montototal)
        {
            VentaWS ventasWS = new VentaWS();
            ventasWS.AgregarVenta(agregarVenta, montototal);
        }

        public List<VentaAgrupada> ObtenerVentasPorUsuario(string idUsuario)
        {

            return ObtenerVentasAgrupadasPorUsuario(idUsuario);
        }


        // Método para obtener las ventas agrupadas por usuario y mes
        public List<VentaAgrupada> ObtenerVentasAgrupadasPorUsuario(string idUsuario)
        {
            List<VentaAgrupada> ventasAgrupadas = new List<VentaAgrupada>();
            DBHelper basedatos = new DBHelper("Ventas");
            var ventas = basedatos.Listar();


            var ventasPorDiaCliente = new HashSet<string>();

            foreach (var venta in ventas)
            {
                string[] detalles = venta.Split('|');
                if (detalles.Length == 7 && detalles[2] == idUsuario)
                {
                    string fecha = detalles[6];

                    string diaClienteKey = $"{detalles[1]}|{DateTime.Parse(fecha).ToString("yyyy-MM-dd")}";

                    decimal montoTotal = decimal.Parse(detalles[5]);
                    string mesAnio = DateTime.Parse(fecha).ToString("yyyy-MM");

                    var ventaExistente = ventasAgrupadas.FirstOrDefault(v => v.MesAnio == mesAnio);

                    if (!ventasPorDiaCliente.Contains(diaClienteKey))
                    {
                        ventasPorDiaCliente.Add(diaClienteKey);
                        if (ventaExistente != null)
                        {
                            ventaExistente.CantidadVentas += 1;
                            ventaExistente.MontoTotal += montoTotal;
                        }
                        else
                        {
                            ventasAgrupadas.Add(new VentaAgrupada
                            {
                                MesAnio = mesAnio,
                                CantidadVentas = 1,
                                MontoTotal = montoTotal
                            });
                        }
                    }
                }
            }

            return ventasAgrupadas;
        }

    }

}


