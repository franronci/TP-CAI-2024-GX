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

        private bool erroresMostrados = false; // Flag para verificar si ya se mostraron errores

        public ModificarContraseña()
        {
            InitializeComponent();

            // Ocultar el Label de errores al iniciar el formulario
            lbErroresContraseña.Visible = false;
            lbErroresContraseña.AutoSize = true;

        }

        

        private void btnConfirmarContraseña_Click(object sender, EventArgs e)
        {
            erroresMostrados = true; // Activar el flag para mostrar errores después del primer clic
            ValidarCamposContraseña(null,null); // Llamar a la validación manualmente al hacer confirmación

            // Si no hay errores, proceder con el cambio de contraseña
            if (!lbErroresContraseña.Visible)
            {
                // Lógica para cambiar la contraseña
                // Por ejemplo, llamar a un método que actualice la contraseña en la base de datos
                MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lbErroresContraseña.Visible = true; // Muestra el Label de errores
                lbErroresContraseña.Text = string.Join("\n", errores); // Asigna los errores al texto del Label
            }
            else
            {
                lbErroresContraseña.Visible = false; // Oculta el Label si no hay errores

            }



        }



    }
       

}
