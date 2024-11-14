using Datos;
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

namespace TemplateTPIntegrador.Reportes
{
    public partial class VendedorReporte : Form
    {
        public VendedorReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Administrador admin = new Administrador();
            int dni_int = int.Parse(txtdni.Text);

            string idUsuario = admin.traeridcondni(dni_int);

            Carrito carrito = new Carrito();
            List<VentaAgrupada> ventasAgrupadas = carrito.ObtenerVentasPorUsuario(idUsuario);

            // Crear una instancia del formulario VentasVendedorForm y pasarle los datos de ventas agrupadas
            VentasVendedor ventasForm = new VentasVendedor(ventasAgrupadas);
            ventasForm.ShowDialog(); // Mostrar el formulario

        }
    }
}
