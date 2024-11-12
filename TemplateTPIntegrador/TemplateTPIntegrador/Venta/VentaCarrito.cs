using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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



        private void CalcularTotalConDescuentos()
        {
            decimal totalCategoria3 = 0;
            decimal totalOtrasCategorias = 0;
            decimal totalConDescuento;

            Carrito carrito = new Carrito();
            Guid idCliente = carrito.traerIDcliente(int.Parse(txtdniclientes.Text));

            foreach (DataGridViewRow row in datagridcarritocompra.Rows)
            {
                if (!row.IsNewRow && (row.Tag == null || row.Tag.ToString() != "TotalRow")) 
                {

                    string categoria = row.Cells["Categoria"].Value != null ? row.Cells["Categoria"].Value.ToString() : string.Empty;

                    if (decimal.TryParse(row.Cells["Total"].Value?.ToString(), out decimal totalProducto))
                    {
                        if (categoria == "3")
                        {
                            totalCategoria3 += totalProducto;
                        }
                        else
                        {
                            totalOtrasCategorias += totalProducto;
                        }
                    }
                }
            }

            if (totalCategoria3 > 100000)
            {
                totalCategoria3 -= totalCategoria3 * 0.05m; 
            }


            totalConDescuento = totalCategoria3 + totalOtrasCategorias;


            bool esPrimeraCompra = !carrito.hayVentaCliente(int.Parse(txtdniclientes.Text));

            if (esPrimeraCompra)
            {
                totalConDescuento -= totalConDescuento * 0.05m;
            }


            txtTotalConDescuento.Text = totalConDescuento.ToString("C");
        }

        private void btnagregarProductocarrito_Click(object sender, EventArgs e)
        {
            decimal totalCarrito = 0;
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


                    foreach (DataGridViewRow row in datagridcarritocompra.Rows)
                    {
                        if (row.Tag != null && row.Tag.ToString() == "TotalRow")
                        {
                            datagridcarritocompra.Rows.Remove(row);
                            break;
                        }
                    }


                    foreach (DataGridViewRow row in datagridcarritocompra.Rows)
                    {
                        if (!row.IsNewRow && (row.Tag == null || row.Tag.ToString() != "TotalRow") && row.Cells["Total"].Value != null)
                        {
                            totalCarrito += Convert.ToDecimal(row.Cells["Total"].Value);
                        }
                    }


                    int rowIndex = datagridcarritocompra.Rows.Add();
                    DataGridViewRow totalRow = datagridcarritocompra.Rows[rowIndex];
                    totalRow.Tag = "TotalRow";
                    totalRow.Cells["Producto"].Value = "TOTAL";
                    totalRow.Cells["Total"].Value = totalCarrito;
                    totalRow.DefaultCellStyle.Font = new Font(datagridcarritocompra.Font, FontStyle.Bold);


                    Task.Delay(50).ContinueWith(_ => this.Invoke((MethodInvoker)delegate { CalcularTotalConDescuentos(); }));
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




        private void btnfinalizarCompra_Click(object sender, EventArgs e)
        {
            if (datagridcarritocompra.Rows.Count > 0)
            {
                Carrito carrito = new Carrito();
                try
                {
                    Guid idCliente = carrito.traerIDcliente(int.Parse(txtdniclientes.Text));
                    string idUsuario = SesionUsuario.IdUsuario;

                    foreach (DataGridViewRow row in datagridcarritocompra.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            try
                            {
                                if (row.Cells[1].Value == null || row.Cells[2].Value == null)
                                {
                                    Console.WriteLine("Producto o cantidad no están definidos en una de las filas.");
                                    continue;
                                }

                                string producto = row.Cells[1].Value.ToString();
                                int cantidad = Convert.ToInt32(row.Cells[2].Value);
                                int categoria = Convert.ToInt32(row.Cells[0].Value);

                                Guid idProducto = carrito.traerIDproducto(producto, categoria);

                                if (idProducto == Guid.Empty)
                                {
                                    Console.WriteLine($"ID de producto no encontrado para '{producto}'.");
                                    continue;
                                }

                                AltaVenta altaVenta = new AltaVenta(idCliente, Guid.Parse(idUsuario), idProducto, cantidad);
                                carrito.AgregarVentaNegocio(altaVenta);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al procesar el producto '{row.Cells[1].Value}': {ex.Message}");
                            }
                        }
                    }

                    MessageBox.Show("Ventas registradas con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al finalizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito para enviar.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtmailcliente_TextChanged(object sender, EventArgs e)
        {
            
            int width = TextRenderer.MeasureText(txtdniclientes.Text, txtdniclientes.Font).Width;

            
            txtmailcliente.Width = width + 10; 
        }

       


    }
}