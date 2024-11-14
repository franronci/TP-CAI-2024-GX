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

namespace TemplateTPIntegrador.Proveedor
{
    public partial class BajaProveedorf : Form
    {
        public BajaProveedorf()
        {
            InitializeComponent();
        }

        private void EliminarProveedor(string idProveedor)
        {
 
            Negocio.Proveedor BajaProveedor = new Negocio.Proveedor();
            BajaProveedor.BorrarProveedor(idProveedor);
        }

        private void txtproveedorBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproveedorBaja_Click(object sender, EventArgs e)
        {
            Negocio.Proveedor administrador = new Negocio.Proveedor();

            string idproveedor = txtproveedorBaja.Text;

            administrador.BorrarProveedor(idproveedor);

            this.Close();
        }
    }
}
