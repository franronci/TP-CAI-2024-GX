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

        private void EliminarProveedor(Guid idProveedor)
        {
 
            Negocio.Proveedor BajaProveedor = new Negocio.Proveedor();
            Guid idUsuario = Guid.Parse(SesionUsuario.IdUsuario);


            BajaProveedor.BorrarProveedor(idProveedor, idUsuario);
        }

        private void txtproveedorBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproveedorBaja_Click(object sender, EventArgs e)
        {
            Negocio.Proveedor administrador = new Negocio.Proveedor();
            Administrador amind = new Administrador();
            Guid idUsuario = Guid.Parse(SesionUsuario.IdUsuario);
            Guid idproveedor = amind.traerproveedorcuit(txtproveedorBaja.Text);   

            administrador.BorrarProveedor(idproveedor, idUsuario);

            Console.WriteLine(idUsuario + " - " + idproveedor);


            this.Close();
        }
    }
}
