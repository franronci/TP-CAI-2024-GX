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
    public partial class AgregarCliente : Form

    {

        private bool erroresMostrados = false;
        public AgregarCliente()
        {
            InitializeComponent();
            NombreCliente.TextChanged += new EventHandler(ValidarCampos);
            ApellidoCliente.TextChanged += new EventHandler(ValidarCampos);
            DireccionCliente.TextChanged += new EventHandler(ValidarCampos); ;
            DocumentoCliente.TextChanged += new EventHandler(ValidarCampos);
            MailCliente.TextChanged += new EventHandler(ValidarCampos); ;
            TelefonoCliente.TextChanged += new EventHandler(ValidarCampos); ;
            HostCliente.TextChanged += new EventHandler(ValidarCampos); ;
           

            Errores1.AutoSize = true;
            Errores1.MaximumSize = new Size(400, 0);
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void DireccionUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {

            erroresMostrados = true;
            ValidarCampos(null, null);
            Cliente cliente = new Cliente();    

            if (!Errores1.Visible)
            {
                string nombre = NombreCliente.Text;
                string apellido = ApellidoCliente.Text;
                string direccion = DireccionCliente.Text;
                string mail = MailCliente.Text;
                int documento = int.Parse(DocumentoCliente.Text);
                DateTime nacimiento = FechaNacimientoCliente.Value;
                string telefono = TelefonoCliente.Text;
                string rol = HostCliente.Text;

                MessageBox.Show(cliente.agregarCliente(SesionUsuario.IdUsuario, nombre, apellido, documento, direccion, telefono, mail, nacimiento, rol));
               
            }


        }


        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string nombre = NombreCliente.Text.ToLower();
            string apellido = ApellidoCliente.Text.ToLower();
            string direccion = DireccionCliente.Text.ToLower();
            string mail = MailCliente.Text.ToLower();
            string documento = DocumentoCliente.Text.ToLower();
            string rol = HostCliente.Text.ToLower();
            string nacimiento = FechaNacimientoCliente.Text.ToLower();
            string telefono = TelefonoCliente.Text.ToLower();


            List<string> errores1 = new List<string>();

            if (validarIntegridad.ValidarStringVacio(nombre) ||
                validarIntegridad.ValidarStringVacio(apellido) ||
                validarIntegridad.ValidarStringVacio(documento) ||
                validarIntegridad.ValidarStringVacio(mail) ||
                validarIntegridad.ValidarStringVacio(rol) ||
                validarIntegridad.ValidarStringVacio(nacimiento) || validarIntegridad.ValidarStringVacio(direccion)
                || validarIntegridad.ValidarStringVacio(telefono))
            {
                errores1.Add("No puede dejar ningún campo vacío.");
            }


            if (erroresMostrados)
            {
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
        }
    }
}
