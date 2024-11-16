using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Clientes;
using TemplateTPIntegrador.Reportes;
using TemplateTPIntegrador.Venta;

namespace TemplateTPIntegrador
{
    public partial class pantallaPrinicpalVendedor : Form
    {
        public pantallaPrinicpalVendedor()
        {
            InitializeComponent();
        }

        private void vtnventa_Click(object sender, EventArgs e)
        {
            VentaCarrito venta = new VentaCarrito();

            venta.ShowDialog();
        }

        private void btnventasporvendedor_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();

            Console.WriteLine(carrito.hayVentaCliente(42689649));
            VentasVendedor vv = new VentasVendedor();
            vv.ShowDialog();
        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente();

            cliente.ShowDialog();
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            ModificarCliente cliente = new ModificarCliente();
            cliente.ShowDialog();
        }
    }
}
