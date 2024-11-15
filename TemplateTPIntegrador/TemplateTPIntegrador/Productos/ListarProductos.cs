using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Persistencia;
using Negocio;

namespace TemplateTPIntegrador.Productos
{
    public partial class ListarProductos : Form
    {
        private Negocio.Producto ProductoNegocio = new Negocio.Producto();
        private Negocio.Proveedor ProveedorNegocio = new Negocio.Proveedor();
        private List<DatosProductoWS> productosCompleta;
        public ListarProductos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;

            // Preparar ComboBox_Categoria
            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Categoria.Items.Add("Todas");
            for (int i = 1; i <= 5; i++)
            {
                ComboBox_Categoria.Items.Add(i.ToString());
            }
            ComboBox_Categoria.SelectedIndex = 0; // Establecer "Todas" como selección predeterminada
            ComboBox_Categoria.SelectedIndexChanged += ComboBox_Categoria_SelectedIndexChanged;  // Suscribir al evento SelectedIndexChanged

            CargarProductos();
        }
        private void CargarProductos()
        {
            try
            {
                productosCompleta = ProductoNegocio.listarProductos(); // Cargar la lista completa de productos
                List<DatosProveedorWS> Proveedor = ProveedorNegocio.listarProveedores();

                if (productosCompleta != null)
                {
 
                }

                // Mostrar todos los productos al cargar inicialmente
                ActualizarDataGridView(productosCompleta);

                Productos.CellFormatting += Productos_CellFormatting; // Suscribirse al evento CellFormatting
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }
        private void ActualizarDataGridView(List<DatosProductoWS> productos)
        {
            var bindingList = new BindingList<DatosProductoWS>(productos ?? new List<DatosProductoWS>());
            var source = new BindingSource(bindingList, null);
            Productos.DataSource = source;
            Productos.Columns["id"].Visible = false;
            Productos.Columns["fechaBaja"].Visible = false;
            Productos.Columns["fechaAlta"].Visible = false;
            Productos.Columns["IDCategoria"].HeaderText = "Categoría";
        }
        private void Productos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda pertenece a la columna "Stock"
            if (Productos.Columns[e.ColumnIndex].Name == "Stock")
            {
                // Verificar si el valor de la celda es "0"
                if (e.Value != null && e.Value.ToString() == "0")
                {
                    // Cambiar el color del texto a rojo
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    // Restablecer el color del texto al valor predeterminado
                    e.CellStyle.ForeColor = Productos.DefaultCellStyle.ForeColor;
                }
            }
        }
        private void InterfazListaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void EliminarProducto(string idProducto)
        {
            Negocio.Producto BajaProducto = new Negocio.Producto();
            BajaProducto.BorrarProducto(idProducto);

        }

        private void Listado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }
        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }

        private void ProductoBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoCategoria = ComboBox_Categoria.SelectedItem.ToString();

            if (textoCategoria == "Todas")
            {
                ActualizarDataGridView(productosCompleta);
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }
            else
            {
                // Filtrar la lista completa de productos por la categoría seleccionada
                List<DatosProductoWS> ProductosFiltrados = productosCompleta
                    .Where(p => p.IdCategoria.ToString() == textoCategoria)
                    .ToList();

                if (ProductosFiltrados.Count > 0)
                {
                    ActualizarDataGridView(ProductosFiltrados);
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para la categoría seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                }
            }
        }
        private void Limpiar()
        {
            ProductoBuscador.Text = "";
            ComboBox_Categoria.SelectedIndex = 0;
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void ProductosLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ProductoBuscador.Text; // Obtener el texto ingresado en el TextBox ProductosBuscador

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            if (Productos.DataSource == null || Productos.Rows.Count == 0) // Verificar si la lista de Productos es nula o está vacía
            {
                MessageBox.Show("La lista de productos se encuentra vacía.\n\nNo hay productos para buscar."); // Manejar el caso en el que la lista de Productos es nula o vacía
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            else
            {
                // Lista para almacenar los Productos que coinciden con la búsqueda
                List<DatosProductoWS> ProductosFiltrados = new List<DatosProductoWS>();

                // Recorrer cada fila en el DataGridView Productos
                foreach (DataGridViewRow fila in Productos.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del Producto
                    string nombreProducto = fila.Cells["Nombre"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de Producto actual
                    if (!string.IsNullOrEmpty(nombreProducto) && nombreProducto.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        // Agregar el Producto a la lista de Productos filtrados
                        ProductosFiltrados.Add((DatosProductoWS)fila.DataBoundItem);
                    }
                }

                if (ProductosFiltrados.Count > 0) // Verificar si se encontraron Productos que coinciden con la búsqueda
                {
                    var bindingList = new BindingList<DatosProductoWS>(ProductosFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Productos.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                }
            }
        }

        private void Boton_AltaProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto AltaProductos = new AgregarProducto();
            Hide();
            AltaProductos.Show();
        }

        private void BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarProductos();
            Limpiar();
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (Productos.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Productos.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idProducto = filaSeleccionada.Cells["id"].Value.ToString(); // Lo voy a reutilizar para el patch y el delete

                int precio = Convert.ToInt32(filaSeleccionada.Cells["Precio"].Value);
                int stock = Convert.ToInt32(filaSeleccionada.Cells["Stock"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();

                ModificarProductosF modificarProductos = new ModificarProductosF(idProducto);
                modificarProductos.ActualizarTextBox(precio, stock, nombre); // Levanto los datos de la lista y me los llevo a otra ventana.

                modificarProductos.Show();
                Hide(); // ocultar la lista de productos momentáneamente.
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en Modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // OJO ACÁ → A esta opción sólo puede entrar el host 2
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            if (Productos.SelectedRows.Count > 0)
            {
                int indiceFila = Productos.SelectedRows[0].Index;

                string idProducto = Productos.Rows[indiceFila].Cells["ID"].Value.ToString();

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Está seguro que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    EliminarProducto(idProducto);
                    MessageBox.Show("Se ha eliminado el Producto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("La eliminación del producto ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                pantallaPrinicpalAdmin ventanaMenu = new pantallaPrinicpalAdmin();
                ventanaMenu.Show();
            }
        }
        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pantallaPrinicpalAdmin InterfazMenu = new pantallaPrinicpalAdmin();
                    InterfazMenu.Show();
                    Hide();
                }

            }
        }
    }
}
