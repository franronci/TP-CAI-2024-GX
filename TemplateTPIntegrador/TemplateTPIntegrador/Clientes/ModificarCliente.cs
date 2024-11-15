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

namespace TemplateTPIntegrador.Clientes
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
            direccionClienteModif.TextChanged += new EventHandler(ValidarCampos);
            DNIClienteModif.TextChanged += new EventHandler(ValidarCampos);
            TelefonoClienteModif.TextChanged += new EventHandler(ValidarCampos);
            mailclientemodif.TextChanged += new EventHandler(ValidarCampos);

            Errores1.AutoSize = true;
            Errores1.MaximumSize = new Size(400, 0);
        }

        private void Btnmodificarcliente_Click(object sender, EventArgs e)
        {
            ValidarCampos(null, null);
            Carrito carrito = new Carrito();
            Cliente cliente = new Cliente();

            if (!Errores1.Visible)
            {
                string dni = DNIClienteModif.Text.ToLower();

                Guid id_cliente = carrito.traerIDcliente(int.Parse(dni));

                string mail = mailclientemodif.Text.ToLower();
                string direccion = direccionClienteModif.Text.ToLower();
                string telefono = TelefonoClienteModif.Text.ToLower();

                MessageBox.Show(cliente.modificarCliente(id_cliente, direccion, telefono, mail));

            }
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string dni = DNIClienteModif.Text.ToLower();
            string mail = mailclientemodif.Text.ToLower();
            string direccion = direccionClienteModif.Text.ToLower();
            string telefono = TelefonoClienteModif.Text.ToLower();

            List<string> errores1 = new List<string>();

            if (validarIntegridad.ValidarStringVacio(dni) ||
                validarIntegridad.ValidarStringVacio(direccion) ||
                validarIntegridad.ValidarStringVacio(telefono) ||
                validarIntegridad.ValidarStringVacio(mail))
            {
                errores1.Add("No puede dejar ningún campo vacío.");
            }

            if (errores1.Count > 0)
            {
                Errores1.Visible = true;
                Errores1.Text = string.Join("\n", errores1);
            }
            else
            {
                Errores1.Visible = false;
            }
        }

        private void Errores1_Click(object sender, EventArgs e)
        {

        }
    }

}
