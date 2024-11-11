using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Venta
{
    public partial class VentaCarrito : Form
    {
        public VentaCarrito()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void boxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (boxCategoria.SelectedIndex == -1)
            {
               
                boxProductosCategoria.DataSource = null;
                boxProductosCategoria.Text = "Seleccione una categoría primero";
            }
            else
            {
                
                Carrito carrito = new Carrito();

                
                int categoria_int = int.Parse(boxCategoria.Text);

                
                List<string> productos = carrito.traerNombreProductos(categoria_int);


                if (productos.Count > 0)
                {
                    boxProductosCategoria.DataSource = productos;
                    boxProductosCategoria.SelectedIndex = -1; // Para que no se seleccione ningún elemento por defecto
                    boxProductosCategoria.Text = "Seleccione un producto";
                }
                else
                {
                    boxProductosCategoria.DataSource = null;
                    boxProductosCategoria.Text = "No hay productos disponibles";
                }
            }
        }

        private void boxProductosCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnagregarProductocarrito_Click(object sender, EventArgs e)
        {
            Carrito ventacarrito = new Carrito();
            int dni = int.Parse(txtdniclientes.Text);

            Console.WriteLine(ventacarrito.traerNombreCliente(42689649));
            Console.WriteLine(ventacarrito.traerApellidoCliente(dni));
            Console.WriteLine(ventacarrito.traerEmailCliente(dni));
        }

        private void btnagregarDNI_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtdniclientes.Text, out int dni))
            {
                Carrito ventacarrito = new Carrito();
                // Actualiza los TextBox con los datos del cliente
                txtnombreCliente.Text = ventacarrito.traerNombreCliente(dni);
                txtapellidoCliente.Text = ventacarrito.traerApellidoCliente(dni);
                txtmailcliente.Text = ventacarrito.traerEmailCliente(dni);
            }
            else
            {
                // Limpia los campos si el DNI no es válido
                txtnombreCliente.Text = "";
                txtapellidoCliente.Text = "";
                txtmailcliente.Text = "";
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
