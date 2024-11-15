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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TemplateTPIntegrador
{
    public partial class ModificarContraseña : Form
    {

        private bool erroresMostrados = false;

        public ModificarContraseña()
        {
            InitializeComponent();

            lbErroresContraseña.Visible = false;
            lbErroresContraseña.AutoSize = true;

        }

        

        private void btnConfirmarContraseña_Click(object sender, EventArgs e)
        {
            erroresMostrados = true; 
            ValidarCamposContraseña(null,null); 
            Administrador administrador = new Administrador();
            InicioSesion inicioSesion = new InicioSesion(); 
            string username = administrador.traerusername();
            string contrasevieja = txtContraseñaActual.Text;
            string contraseñanueva = txtNuevaContraseña.Text;

            if (!lbErroresContraseña.Visible)
            {
                string respuesta = inicioSesion.cambiarContraseña(username, contrasevieja, contraseñanueva);
                Console.WriteLine($" {contraseñanueva} , {contrasevieja}, {username} ");


                if (respuesta == "Contraseña cambiada exitosamente.")
                {
                    MessageBox.Show(respuesta);
                    Login login = new Login();

                    login.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show(respuesta);
                }

            }
        }

        private void ValidarCamposContraseña(object value1, object value2)
        {
            throw new NotImplementedException();
        }

        private void ValidarCamposContraseña(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string contraseñaActual = txtContraseñaActual.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;

            List<string> errores = new List<string>();

            if (validarIntegridad.ValidarStringVacio(contraseñaActual) ||
               validarIntegridad.ValidarStringVacio(nuevaContraseña))
            {
                errores.Add("No puede dejar ningún campo vacío.");
            }

            if (!validarNegocio.ValidarLongitudContraseña(nuevaContraseña))
                errores.Add("La contraseña debe tener entre 8 y 15 caracteres.");

            if (!validarNegocio.ValidarMayusculaYNumero(nuevaContraseña))
                errores.Add("La contraseña debe contener al menos una letra mayúscula y al menos un número.");

            if (!validarNegocio.ValidarNoRepetida(nuevaContraseña, contraseñaActual))
                errores.Add("La nueva contraseña no puede ser igual a la anterior.");

            if (errores.Count > 0)
            {
                lbErroresContraseña.Visible = true; 
                lbErroresContraseña.Text = string.Join("\n", errores); 
            }
            else
            {
                lbErroresContraseña.Visible = false; 

            }



        }

        private void ModificarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
       

}
