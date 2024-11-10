using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;
namespace Negocio
{
    public class Venta
    {
        private VentaWS ventaServicio = new VentaWS();
        public DatosVentaWS traerVenta()
        {
            return ventaServicio.GetVenta();
        }
        public void agregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            AltaVenta altaVenta = new AltaVenta(idCliente, idUsuario, idProducto, cantidad);
            ventaServicio.AgregarVenta(altaVenta);

        }

        public void devolverVenta(string idVenta, string idUsuario)
        {
            ventaServicio.DevolverVenta(idVenta, idUsuario);
        }

        public List<VentaPorCliente> GetVentaPorClientes(string idCliente)
        {
            return ventaServicio.GetVentasCliente(idCliente);
        }


    }
}
