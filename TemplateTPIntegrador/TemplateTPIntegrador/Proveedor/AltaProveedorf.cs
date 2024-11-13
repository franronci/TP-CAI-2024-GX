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

        private void CrearProveedor()
        {
            Negocio.Proveedor AltaProveedor = new Negocio.Proveedor();
            AltaProveedor.AgregarProveedor("70b37dc1-8fde-4840-be47-9ababd0ee7e5", Nombre_Box.Text, Apellido_Box.Text, Email_Box.Text, CUIT_Box.Text);
        }
        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {

        } // Confirma todos los campos, si está todo correcto, genera un ID de proveedor.
        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el alta del proveedor?\n\nLos cambios no se guardarán.", "Cancelar Alta de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                ListaProveedores listaProveedores = new ListaProveedores();
                listaProveedores.Show();
                Close();
            }
        }
        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void Boton_Cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el alta del proveedor?\n\nLos cambios no se guardarán.", "Cancelar Alta de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                ListaProveedores listaProveedores = new ListaProveedores();
                listaProveedores.Show();
                Close();
            }
        }

        private void Boton_Confimar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearProveedor();

                DialogResult resultadoConfirmacion = MessageBox.Show("¿Desea realizar la operación de alta para el Proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha realizado la operación de alta para el Proveedor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea continuar dando de alta proveedores?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        ListaProveedores InterfazListaProveedores = new ListaProveedores();
                        InterfazListaProveedores.Show();
                    }
                    else
                    {
                        Limpiar();
                    }
                }
            }
        }

        private void MayudaNombre_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el nombre:\n" +
                         "1. No se permite dejar el campo vacio.\n" +
                         "2. Deben ser por lo menos 3 caracteres.\n" +
                         "3. No deben ser numeros.\n" +
                         "4. No se permiten caracteres especiales.";

            MessageBox.Show(mensaje);
        }

        private void MayudaApellido_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el apellido:\n" +
                         "1. No se permite dejar el campo vacio.\n" +
                         "2. Deben ser por lo menos 3 caracteres.\n" +
                         "3. No deben ser numeros.\n" +
                         "4. No se permiten caracteres especiales.";

            MessageBox.Show(mensaje);
        }

        private void MayudaMail_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el correo:\n" +
                         "1. No se permite dejar el campo vacio.\n" +
                         "2. El correo debe tener el dominio @G3.com.\n" +
                         "3. El correo no puede contener espacios en blanco.\n"
                         ;

            MessageBox.Show(mensaje);
        }

        private void MayudaCUIT_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el CUIT:\n" +
                          "1. No se permite dejar el campo vacio.\n" +
                          "2. El campo CUIT debe tener exactamente 11 dígitos.\n" +
                          "3. El campo CUIT debe contener solo dígitos numéricos.\n" +
                          "4. El primer dígito del CUIT debe ser 2 o 3.";

            MessageBox.Show(mensaje);
        }
    }
}
