using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System.Net.Http;
using System.Windows.Forms;

namespace Negocio
{
    public class Venta
    {
        private VentaWS ventaServicio = new VentaWS();
        public DatosVentaWS traerVenta()
        {
            return ventaServicio.GetVenta();
        }
        public void agregarVenta(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad, decimal montotal)
        {
            AltaVenta altaVenta = new AltaVenta(idCliente, idUsuario, idProducto, cantidad);
            ventaServicio.AgregarVenta(altaVenta, montotal);

        }

        public void devolverVenta(Guid idVenta, Guid idUsuario)
        {
            ventaServicio.DevolverVenta(idVenta, idUsuario);
        }

        public List<VentaPorCliente> GetVentaPorClientes(Guid idCliente)
        {
            return ventaServicio.GetVentasCliente(idCliente);
        }

     
    }
}
