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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            InicioSesion login = new InicioSesion();

            string usuario = txtboxUsernameLogin.Text;
            string password = txtboxPasswordLogin.Text;

            string id = login.HacerLogin(usuario, password);

            MessageBox.Show(id);
        }
    }
}
