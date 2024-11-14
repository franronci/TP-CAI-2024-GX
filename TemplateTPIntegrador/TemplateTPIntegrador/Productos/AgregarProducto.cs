using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Datos;
using Negocio;

namespace TemplateTPIntegrador.Productos
{
    public partial class AgregarProducto : Form
    {
        private Negocio.Proveedor ProveedorNegocio = new Negocio.Proveedor();
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarProducto_Click(object sender, EventArgs e)
        {
        }
    }
}
