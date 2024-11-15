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

namespace TemplateTPIntegrador.Productos
{
    public partial class ModificarProductosF : Form
    {
        private string idProducto;
        public ModificarProductosF(string idProducto)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            this.idProducto = idProducto;

            // Bloquear los TextBox
            Box_Nombre.ReadOnly = true;
            Box_PActual.ReadOnly = true;
            Box_SActual.ReadOnly = true;
        }
        public void ActualizarTextBox(int precio, int stock, string nombre)
        {
            Box_PActual.Text = precio.ToString();
            Box_SActual.Text = stock.ToString();
            Box_Nombre.Text = nombre.ToString();
        }
        private int ControlarCampos()
        {
            int ContarErrores = 0;

            string errorPrecio = ValidacionesDeNegocio.EsPrecio(Box_PNuevo.Text.ToString(), "Precio");
            if (errorPrecio != null)
            {
                Precio_Error.Text = errorPrecio;
                Precio_Error.Visible = true;
                MessageBox.Show(errorPrecio, "Revisar el dato:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaPrecio.Visible = true;
                ContarErrores++;
            }

            else
            {
                Precio_Error.Visible = false;
                MayudaPrecio.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorStock = ValidacionesDeNegocio.EsStock(Box_SNuevo.Text.ToString(), "Stock");
            if (errorStock != null)
            {
                Stock_Error.Text = errorStock;
                Stock_Error.Visible = true;
                MessageBox.Show(errorStock, "Revisar el dato:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaStock.Visible = true;
                ContarErrores++;
            }

            else
            {
                Stock_Error.Visible = false;
                MayudaStock.Visible = false;
            }
            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }
            return ContarErrores;
        }

        private void ModificarProductos_Load(object sender, EventArgs e)
        {

        }

        public void ModificarProductos(string idProducto)
        {
            string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

            Negocio.Producto ProductoNegocio = new Negocio.Producto();
            ProductoNegocio.ModificarProducto(
                                            idProducto,
                                            idUsuario,
                                            Convert.ToInt32(Box_PNuevo.Text),
                                            Convert.ToInt32(Box_SNuevo.Text)
                                         );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea cancelar la modificación?\n\nNo se guardará ningún cambio.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                Close();
                ListarProductos listaProductos = new ListarProductos();
                listaProductos.Show();
            }
            else
            {
            }
        }
        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de productos?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ListarProductos ListaProductos = new ListarProductos();
                    ListaProductos.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void btnmodfiicarProducto_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    ModificarProductos(idProducto);

                    MessageBox.Show($"Se ha realizado la modificación con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                    ListarProductos listaProductos = new ListarProductos();
                    listaProductos.Show();
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "No se puede modificar precio actual directamente, debe indicar un precio nuevo";

            MessageBox.Show(mensaje);
        }

        private void MayudaStock_Click(object sender, EventArgs e)
        {
            string mensaje = "No se puede modificar stock actual directamente, debe indicar un stock nuevo";

            MessageBox.Show(mensaje);
        }

        private void MayudaPrecio_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el precio:\n" +
             "1. No se permite dejar el campo vacio.\n" +
             "2. El precio debe ser un numero positivo.\n" +
             "3. El precio no puede ser superior a 20.000.000.\n";

            MessageBox.Show(mensaje);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "Tener en cuenta para completar el nombre:\n" +
             "1. No se permite dejar el campo vacio.\n" +
             "2. El stock debe ser un numero positivo.\n" +
             "3. El stock no puede ser mayor a 1000.\n" +
             "4. No se permiten letras ni caracteres especiales.";

            MessageBox.Show(mensaje);
        }
    }
}
