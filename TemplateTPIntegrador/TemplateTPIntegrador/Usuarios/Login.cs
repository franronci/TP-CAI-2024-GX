using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            erroresMostrados = true; 
            ValidarCampos(null, null); 

            
            if (!Errores_login.Visible)
            {
                InicioSesion inicioSesion = new InicioSesion();
                string id_usuario = inicioSesion.HacerLogin(txtboxUsernameLogin.Text, txtboxPasswordLogin.Text);
                Administrador administrador = new Administrador();
                
                if(id_usuario != null)
                {
                    inicioSesion.GuardarDatos(id_usuario, txtboxUsernameLogin.Text);
                    string nombre = administrador.traernombreid(id_usuario);
                    string apellido = administrador.traerapellidoid(id_usuario);
                    int dni = administrador.traedniid(id_usuario);


                    if (inicioSesion.esPrimeraSesion(txtboxPasswordLogin.Text, nombre,apellido,dni))
                    {

                        var modifcontrasñaForm = new ModificarContraseña();
                        modifcontrasñaForm.Show();
                        this.Hide();

                    }
                    else if (inicioSesion.TraerHost(id_usuario) == 1)
                    {
                        // Crear una instancia del formulario del vendedor
                        var vendedorForm = new pantallaPrinicpalVendedor();
                        vendedorForm.Show(); // Muestra el formulario
                        this.Hide(); // Oculta el formulario de inicio de sesión
                    }
                    else if (inicioSesion.TraerHost(id_usuario) == 2)
                    {
                        // Crear una instancia del formulario del supervisor
                        var supervisorForm = new pantallaPrinicpalSupervisor();
                        supervisorForm.Show(); // Muestra el formulario
                        this.Hide(); // Oculta el formulario de inicio de sesión
                    }
                    else if (inicioSesion.TraerHost(id_usuario) == 3)
                    {
                        // Crear una instancia del formulario del admin
                        var adminForm = new pantallaPrinicpalAdmin();
                        adminForm.Show(); // Muestra el formulario
                        this.Hide(); // Oculta el formulario de inicio de sesión
                    }
                  
                }

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
            if (validarIntegridad.ValidarStringVacio(username) ||
                validarIntegridad.ValidarStringVacio(password))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }

            // Validar el largo del username
            if (validarNegocio.ValidarLargoUserPass(username))
            {
                errores.Add("El nombre de usuario debe tener entre 8 y 15 caracteres.");
            }

            // Validar el largo de la contraseña
            if (validarNegocio.ValidarLargoUserPass(password))
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtboxPasswordLogin.UseSystemPasswordChar = true;
        }

        private void button_Verpw_Click(object sender, EventArgs e)
        {
            // Verifica si los caracteres están actualmente ocultos
            if (txtboxPasswordLogin.UseSystemPasswordChar)
            {
                // Muestra los caracteres
                txtboxPasswordLogin.UseSystemPasswordChar = false;
                button_Verpw.Text = "Ocultar"; // Cambia el texto del botón
            }
            else
            {
                // Oculta los caracteres
                txtboxPasswordLogin.UseSystemPasswordChar = true;
                button_Verpw.Text = "Mostrar"; // Cambia el texto del botón
            }
        }
    }
}



