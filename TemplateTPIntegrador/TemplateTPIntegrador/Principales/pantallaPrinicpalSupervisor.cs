using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
using TemplateTPIntegrador.Productos;
using TemplateTPIntegrador.Proveedor;
using TemplateTPIntegrador.Reportes;

namespace TemplateTPIntegrador
{
    public partial class pantallaPrinicpalSupervisor : Form
    {
        public pantallaPrinicpalSupervisor()
        {
            InitializeComponent();
        }

        private void btnaltaProductos_Click(object sender, EventArgs e)
        {
            AgregarProducto formagregarProducto = new AgregarProducto();

            formagregarProducto.ShowDialog();
        }

        private void btnmodificarProducto_Click(object sender, EventArgs e)
        {
            ListarProductos formmodificarProductos = new ListarProductos();

            formmodificarProductos.ShowDialog();
        }
    }
}
