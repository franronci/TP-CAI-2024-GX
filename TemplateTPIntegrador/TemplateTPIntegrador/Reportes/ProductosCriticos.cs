using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TemplateTPIntegrador.Reportes
{
    public partial class ProductosCriticos : Form
    {
        public ProductosCriticos()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configurar DataGridView al inicio
        }

        private void ProductosCriticos_Load(object sender, EventArgs e)
        {
            int stockLimite = 10; // Definir el límite del stock crítico
            CargarProductosCriticos(stockLimite); // Cargar los productos
        }

        private void ConfigurarDataGridView()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("Categoria", "Categoría");
            dataGridView2.Columns.Add("Producto", "Producto");
            dataGridView2.Columns.Add("Stock", "Stock Disponible");

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;
        }

        private void CargarProductosCriticos(int stockLimite)
        {
            Producto carrito = new Producto();
            Dictionary<int, List<DatosProductoWS>> productosPorCategoria = carrito.ObtenerProductosPorCategoriaConStockBajo(stockLimite);

            dataGridView2.Rows.Clear();

            foreach (var categoria in productosPorCategoria)
            {
                int categoriaId = categoria.Key;

                foreach (var producto in categoria.Value)
                {
                    dataGridView2.Rows.Add(categoriaId, producto.Nombre, producto.Stock);
                }
            }
        }

        private void btncarga_Click(object sender, EventArgs e)
        {
            CargarProductosCriticos(10);
        }
    }

}