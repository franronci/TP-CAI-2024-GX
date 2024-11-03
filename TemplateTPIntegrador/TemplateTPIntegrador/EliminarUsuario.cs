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

namespace TemplateTPIntegrador
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnusuarioeliminar_Click(object sender, EventArgs e)
        {

            Administrador administrador = new Administrador();

            string username_eliminar = usuarioEliminar.Text;

            administrador.eliminarUsuario(username_eliminar);

        }
    }
}
