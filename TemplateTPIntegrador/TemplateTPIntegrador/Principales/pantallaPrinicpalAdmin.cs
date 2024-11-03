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
    }
}
