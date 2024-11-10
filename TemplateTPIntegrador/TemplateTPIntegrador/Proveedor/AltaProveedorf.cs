using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace TemplateTPIntegrador.Proveedor
{
    public partial class AltaProveedorf : Form
    {
        public AltaProveedorf()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }
        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorNombre = ValidacionesDeNegocio.EsNombre(Nombre_Box.Text, "Nombre");
            if (errorNombre != null)
            {
                MessageBox.Show(errorNombre, "Verificar el Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                MayudaNombre.Visible = false;
                Nombre_Error.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorApellido = ValidacionesDeNegocio.EsNombre(Apellido_Box.Text, "Apellido");
            if (errorApellido != null)
            {
                MessageBox.Show(errorApellido, "Verificar el Apellido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MayudaApellido.Visible = true;
                ContarErrores++;
            }
            else
            {
                Apellido_Error.Visible = false;
                MayudaApellido.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorMail = ValidacionesDeNegocio.MailProveedor(Email_Box.Text);
            if (errorMail != null)
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Verificar el Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                Mail_Error.Visible = false;
                MayudaMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorCUIT = ValidacionesDeNegocio.EsCUIT(CUIT_Box.Text);
            if (errorCUIT != null)
            {
                CUIT_Error.Text = errorCUIT;
                CUIT_Error.Visible = true;

                MessageBox.Show(errorCUIT, "Verificar CUIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaCUIT.Visible = true;
                ContarErrores++;
            }
            else
            {
                CUIT_Error.Visible = false;
                MayudaCUIT.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        }

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados
            Nombre_Box.Text = "";
            Apellido_Box.Text = "";
            Email_Box.Text = "";
            CUIT_Box.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
