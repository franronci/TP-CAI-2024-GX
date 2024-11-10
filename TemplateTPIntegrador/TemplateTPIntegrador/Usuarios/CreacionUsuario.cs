using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class CreacionCliente : Form
    {
        private bool erroresMostrados = false; 

        public CreacionCliente()
        {
            InitializeComponent();

            
            NombreUsuario.TextChanged += new EventHandler(ValidarCampos);
            ApellidoUsuario.TextChanged += new EventHandler(ValidarCampos);
            UsernameUsuario.TextChanged += new EventHandler(ValidarCampos);;
            DocumentoUsuario.TextChanged += new EventHandler(ValidarCampos);
            MailUsuario.TextChanged += new EventHandler(ValidarCampos);;
            TelefonoUsuario.TextChanged += new EventHandler(ValidarCampos);;
            RolUsuario.TextChanged += new EventHandler(ValidarCampos);;
            DireccionUsuario.TextChanged += new EventHandler(ValidarCampos);;

           
            Errores.AutoSize = true;
            Errores.MaximumSize = new Size(400, 0); 

        }

        private void ApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UsernameUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void DocumentoUsuario_TextChanged (object sender, EventArgs e)
        {

        }

        private void MailUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void RolUsuario_TextChanged(Object sender, EventArgs e)
        {

        }

        private void DireccionUsuario_TextChanged(Object sender, EventArgs e)
        {

        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            erroresMostrados = true; 
            ValidarCampos(null, null); 

            if (!Errores.Visible)
            {

                string nombre = NombreUsuario.Text;
                string apellido = ApellidoUsuario.Text;
                string username = UsernameUsuario.Text;
                string mail = MailUsuario.Text;
                string host = RolUsuario.Text;
                string documento = DocumentoUsuario.Text;
                int documento_int = int.Parse(documento);
                string telefono = TelefonoUsuario.Text;
                DateTime nacimiento = FechaNacimientoUsuario.Value;
                string fechaFormateada = nacimiento.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
                int host_int;
                string direccion = DireccionUsuario.Text;
                Administrador admin = new Administrador();

                if (host == "Vendedor")
                {
                    host_int = 1;
                }
                else
                {
                    host_int = 2;
                }


                admin.agregarUsuario(host_int, nombre, apellido, documento_int, direccion, telefono, mail, fechaFormateada, username);

            }
            

        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string nombre = NombreUsuario.Text.ToLower();
            string apellido = ApellidoUsuario.Text.ToLower();
            string username = UsernameUsuario.Text.ToLower();
            string direccion = DireccionUsuario.Text.ToLower();
            string mail = MailUsuario.Text.ToLower();
            string documento = DocumentoUsuario.Text.ToLower();
            string rol = RolUsuario.Text.ToLower();
            string nacimiento = FechaNacimientoUsuario.Text.ToLower();
            string telefono = TelefonoUsuario.Text.ToLower();


            List<string> errores = new List<string>();

            if (validarIntegridad.ValidarStringVacio(nombre) ||
                validarIntegridad.ValidarStringVacio(apellido) ||
                 validarIntegridad.ValidarStringVacio(username) ||
                validarIntegridad.ValidarStringVacio(documento) ||
                validarIntegridad.ValidarStringVacio(mail) ||
                validarIntegridad.ValidarStringVacio(rol) ||
                validarIntegridad.ValidarStringVacio(nacimiento) || validarIntegridad.ValidarStringVacio(direccion)
                || validarIntegridad.ValidarStringVacio(telefono))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }


            if (validarNegocio.ValidarNombreApellido(nombre, apellido, username))
            {
                errores.Add("El nombre de usuario no puede contener ni su nombre ni su apellido.");
            }

            if (validarNegocio.ValidarLargoUserPass(username))
            {
                errores.Add("El usuario debe tener entre 8 y 15 caracteres.");
            }


            if (erroresMostrados)
            {
                if (errores.Count > 0)
                {
                    Errores.Visible = true; 
                    Errores.Text = string.Join("\n", errores); 
                }
                else
                {
                    Errores.Visible = false; 
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
