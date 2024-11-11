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
                    boxProductosCategoria.SelectedIndex = -1; 
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
            Carrito carrito = new Carrito();

            if (boxProductosCategoria.SelectedItem != null)
            {
                string productoSeleccionado = boxProductosCategoria.SelectedItem.ToString();
                int categoria = int.Parse(boxCategoria.Text);

                
                double precioUnitario = carrito.precioProducto(productoSeleccionado, categoria);
                txtPreciounitario.Text = precioUnitario.ToString();

                
                if (int.TryParse(numericCantidad.Text, out int cantidad))
                {
                    double total = precioUnitario * cantidad;
                    txtTotal.Text = total.ToString();
                }
                else
                {
                    txtTotal.Text = "";
                }
            }
            else
            {
                txtPreciounitario.Text = "";
                txtTotal.Text = "";
            }
        }

        private void btnagregarDNI_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtdniclientes.Text, out int dni))
            {
                Carrito ventacarrito = new Carrito();
                
                txtnombreCliente.Text = ventacarrito.traerNombreCliente(dni);
                txtapellidoCliente.Text = ventacarrito.traerApellidoCliente(dni);
                txtmailcliente.Text = ventacarrito.traerEmailCliente(dni);
            }
            else
            {
                
                txtnombreCliente.Text = "";
                txtapellidoCliente.Text = "";
                txtmailcliente.Text = "";
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            if (numericCantidad.Value > 0 && int.TryParse(txtPreciounitario.Text, out int precioUnitario))
            {
                int cantidad = (int)numericCantidad.Value;
                double total = precioUnitario * cantidad;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (numericCantidad.Value > 0 && int.TryParse(txtPreciounitario.Text, out int precioUnitario))
            {
                int cantidad = (int)numericCantidad.Value;
                double total = precioUnitario * cantidad;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Text = "";
            }
        }


        
        private void btnagregarProductocarrito_Click(object sender, EventArgs e)
        {
            
            if (boxCategoria.SelectedItem != null && boxProductosCategoria.SelectedItem != null && numericCantidad.Value > 0 && int.TryParse(txtPreciounitario.Text, out int precioUnitario))
            {
                Carrito carrito = new Carrito();
                string productoSeleccionado = boxProductosCategoria.SelectedItem.ToString();
                int categoria = int.Parse(boxCategoria.Text);

                
                int stockDisponible = carrito.traerStockProducto(productoSeleccionado, categoria);
                int cantidad = (int)numericCantidad.Value;

                if (cantidad <= stockDisponible)
                {
                    string categoriaNombre = boxCategoria.SelectedItem.ToString();
                    int total = precioUnitario * cantidad;

                    
                    datagridcarritocompra.Rows.Add(categoriaNombre, productoSeleccionado, cantidad, precioUnitario, total);

                    
                    boxProductosCategoria.SelectedIndex = -1;
                    boxProductosCategoria.Text = "Seleccione un producto";
                    numericCantidad.Value = 0;
                    txtPreciounitario.Text = "";
                    txtTotal.Text = "";
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock disponible para el producto seleccionado.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría y un producto, ingrese una cantidad válida y asegúrese de que el precio unitario esté disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
