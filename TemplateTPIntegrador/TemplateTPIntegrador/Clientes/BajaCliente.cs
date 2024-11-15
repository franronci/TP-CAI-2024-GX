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
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
            DNIClienteBaja.TextChanged += new EventHandler(ValidarCampos);


            Errores1.AutoSize = true;
            Errores1.MaximumSize = new Size(400, 0);
        }

        private void Btnbajacliente_Click(object sender, EventArgs e)
        {

            ValidarCampos(null, null);
            Carrito carrito = new Carrito();
            Cliente cliente = new Cliente();

            if (!Errores1.Visible)
            {
                int dni_int = int.Parse(DNIClienteBaja.Text);

                Guid id_cliente = carrito.traerIDcliente(dni_int);

                cliente.BorrarCliente(id_cliente);

            }


        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            ValidacionesDeNegocio validarNegocio = new ValidacionesDeNegocio();
            ValidacionesIntegridad validarIntegridad = new ValidacionesIntegridad();

            string dni = DNIClienteBaja.Text.ToLower();


            List<string> errores1 = new List<string>();

            if (validarIntegridad.ValidarStringVacio(dni))
      
            {
                errores1.Add("No puede dejar ningún campo vacío.");
            }

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

        private void Errores1_Click(object sender, EventArgs e)
        {

        }
    }
}
