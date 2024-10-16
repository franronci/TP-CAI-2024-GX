using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class frmCreacionUsuario : Form
    {
        private bool erroresMostrados = false; // Flag para verificar si ya se mostraron errores

        public frmCreacionUsuario()
        {
            InitializeComponent();

            // Asignar eventos TextChanged a los TextBox
            txtNombreUsuario.TextChanged += new EventHandler(ValidarCampos);
            txtApellidoUsuario.TextChanged += new EventHandler(ValidarCampos);
            txtUsernameUsuario.TextChanged += new EventHandler(ValidarCampos);;

            // Configurar el Label de errores
            lblErrores.AutoSize = true;
            lblErrores.MaximumSize = new Size(400, 0); // Ajusta el ancho máximo según tu diseño

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

            string nombre = txtNombreUsuario.Text.ToLower();
            string apellido = txtApellidoUsuario.Text.ToLower();
            string username = txtUsernameUsuario.Text.ToLower();

            List<string> errores = new List<string>();

            // Validar que no haya campos vacíos
            if (validarIntegridad.validarStringVacio(nombre) ||
                validarIntegridad.validarStringVacio(apellido) ||
                validarIntegridad.validarStringVacio(username))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }

            // Validar que el username no contenga el nombre ni el apellido del usuario
            if (validarNegocio.validarNombreApellido(nombre, apellido, username))
            {
                errores.Add("El nombre de usuario no puede contener ni su nombre ni su apellido.");
            }

            if (validarNegocio.validarLargoUserPass(username))
            {
                errores.Add("El usuario debe tener entre 8 y 15 caracteres.");
            }

            // Mostrar errores en el Label si existen y si el flag está activado (después del primer clic en Crear Usuario)
            if (erroresMostrados)
            {
                if (errores.Count > 0)
                {
                    lblErrores.Visible = true; // Mostrar el Label si hay errores
                    lblErrores.Text = string.Join("\n", errores); // Actualizar el texto del Label con los errores
                }
                else
                {
                    lblErrores.Visible = false; // Ocultar el Label si no hay errores
                }
            }
        }

        private void RolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FechaNacimientoUsuario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
