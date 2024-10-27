using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class CreacionUsuario : Form
    {
        private bool erroresMostrados = false; // Flag para verificar si ya se mostraron errores

        public CreacionUsuario()
        {
            InitializeComponent();

            // Asignar eventos TextChanged a los TextBox
            NombreUsuario.TextChanged += new EventHandler(ValidarCampos);
            ApellidoUsuario.TextChanged += new EventHandler(ValidarCampos);

            UsernameUsuario.TextChanged += new EventHandler(ValidarCampos);;

            UsernameUsuario.TextChanged += new EventHandler(ValidarCampos);
            DocumentoUsuario.TextChanged += new EventHandler(ValidarCampos);


            // Configurar el Label de errores
            Errores.AutoSize = true;
            Errores.MaximumSize = new Size(400, 0); // Ajusta el ancho máximo según tu diseño

        }

        private void ApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            // El manejo de eventos puede quedar vacío ya que ValidarCampos maneja todas las validaciones necesarias
        }

        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            // El manejo de eventos puede quedar vacío ya que ValidarCampos maneja todas las validaciones necesarias
        }

        private void UsernameUsuario_TextChanged(object sender, EventArgs e)
        {
            // El manejo de eventos puede quedar vacío ya que ValidarCampos maneja todas las validaciones necesarias
        }

        private void ContraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            // El manejo de eventos puede quedar vacío ya que ValidarCampos maneja todas las validaciones necesarias
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            erroresMostrados = true; // Activar el flag para mostrar errores después del primer clic en Crear Usuario
            ValidarCampos(null, null); // Llamar a la validación manualmente al crear usuario
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string nombre = NombreUsuario.Text.ToLower();
            string apellido = ApellidoUsuario.Text.ToLower();
            string username = UsernameUsuario.Text.ToLower();

            string mail = MailUsuario.Text.ToLower();
            string documento = DocumentoUsuario.Text.ToLower();
            string rol = RolUsuario.Text.ToLower();
            string nacimiento = FechaNacimientoUsuario.Text.ToLower();


            List<string> errores = new List<string>();

            // Validar que no haya campos vacíos
            if (validarIntegridad.ValidarStringVacio(nombre) ||
                validarIntegridad.ValidarStringVacio(apellido) ||
                 validarIntegridad.ValidarStringVacio(username) ||
                validarIntegridad.ValidarStringVacio(documento) ||
                validarIntegridad.ValidarStringVacio(mail) ||
                validarIntegridad.ValidarStringVacio(rol) ||
                validarIntegridad.ValidarStringVacio(nacimiento))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }



            // Validar que el username no contenga el nombre ni el apellido del usuario
            if (validarNegocio.ValidarNombreApellido(nombre, apellido, username))
            {
                errores.Add("El nombre de usuario no puede contener ni su nombre ni su apellido.");
            }

            if (validarNegocio.ValidarLongitudContraseña(username))
            {
                errores.Add("El usuario debe tener entre 8 y 15 caracteres.");
            }

            // Mostrar errores en el Label si existen y si el flag está activado (después del primer clic en Crear Usuario)
            if (erroresMostrados)
            {
                if (errores.Count > 0)
                {
                    Errores.Visible = true; // Mostrar el Label si hay errores
                    Errores.Text = string.Join("\n", errores); // Actualizar el texto del Label con los errores
                }
                else
                {
                    Errores.Visible = false; // Ocultar el Label si no hay errores
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
