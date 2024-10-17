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

        private bool erroresMostrados = false; // Flag para verificar si ya se mostraron errores

        public Login()
        {
            InitializeComponent();

            // Asignar eventos TextChanged a los TextBox
            txtboxUsernameLogin.TextChanged += new EventHandler(ValidarCampos);
            txtboxPasswordLogin.TextChanged += new EventHandler(ValidarCampos);

            // Configurar el Label de errores
            Errores_login.AutoSize = true;
            Errores_login.MaximumSize = new Size(400, 0); // Ajusta el ancho máximo según tu diseño
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            erroresMostrados = true; // Activar el flag para mostrar errores después del primer clic en Login
            ValidarCampos(null, null); // Llamar a la validación manualmente al hacer login

            // Si no hay errores, proceder con la validación final de los datos ingresados
            if (!Errores_login.Visible)
            {
                // Rellena aquí la validación de datos (por ejemplo, intentar hacer el login)
                // Este bloque se ejecutará solo si no hay errores
                // Ejemplo:
                MessageBox.Show("hola");
            }
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string username = txtboxUsernameLogin.Text.ToLower();
            string password = txtboxPasswordLogin.Text.ToLower();

            List<string> errores = new List<string>();

            // Validar que no haya campos vacíos
            if (validarIntegridad.validarStringVacio(username) ||
                validarIntegridad.validarStringVacio(password))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }

            // Validar el largo del username
            if (validarNegocio.validarLargoUserPass(username))
            {
                errores.Add("El nombre de usuario debe tener entre 8 y 15 caracteres.");
            }

            // Validar el largo de la contraseña
            if (validarNegocio.validarLargoUserPass(password))
            {
                errores.Add("La contraseña debe tener entre 8 y 15 caracteres.");
            }

            // Mostrar errores en el Label si existen y si el flag está activado (después del primer clic en Login)
            if (erroresMostrados)
            {
                if (errores.Count > 0)
                {
                    Errores_login.Visible = true; // Mostrar el Label si hay errores
                    Errores_login.Text = string.Join("\n", errores); // Actualizar el texto del Label con los errores
                }
                else
                {
                    Errores_login.Visible = false; // Ocultar el Label si no hay errores
                }
            }
        }
    }
}



