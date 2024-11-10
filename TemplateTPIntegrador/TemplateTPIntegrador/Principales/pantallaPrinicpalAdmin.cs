using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.Proveedor;

namespace TemplateTPIntegrador
{
    public partial class pantallaPrinicpalAdmin : Form
    {
        public pantallaPrinicpalAdmin()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            CreacionUsuario formCreacionUsuario = new CreacionUsuario();
            formCreacionUsuario.ShowDialog();
        }

        private void btnbajausuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario formeliminarUsuario = new EliminarUsuario();
            formeliminarUsuario.ShowDialog();

        }

        private void btnActivarusuario_Click(object sender, EventArgs e)
        {
            ActivarUsuario formactivarUsuario = new ActivarUsuario();

            formactivarUsuario.ShowDialog();

        }

        private void btnaltaProveedor_Click(object sender, EventArgs e)
        {
            AltaProveedorf fromaaltaProveedor = new AltaProveedorf();

            fromaaltaProveedor.ShowDialog();
        }

        private void btnbajaProveedor_Click(object sender, EventArgs e)
        {
            BajaProveedorf formabajaProveedor = new BajaProveedorf();

            formabajaProveedor.ShowDialog();
        }

        private void btnmodificarproveedor_Click(object sender, EventArgs e)
        {
            ModificarProveedorf formamodificarProveedor = new ModificarProveedorf();

            formamodificarProveedor.ShowDialog();
        }
    }
}
