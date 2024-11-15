using Datos;
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
            dataGridViewProductosCriticos.Columns.Clear();
            dataGridViewProductosCriticos.Columns.Add("Categoria", "Categoría");
            dataGridViewProductosCriticos.Columns.Add("Producto", "Producto");
            dataGridViewProductosCriticos.Columns.Add("Stock", "Stock Disponible");

            dataGridViewProductosCriticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductosCriticos.AllowUserToAddRows = false;
            dataGridViewProductosCriticos.ReadOnly = true;
        }

        private void CargarProductosCriticos(int stockLimite)
        {
            Producto carrito = new Producto();
            Dictionary<int, List<DatosProductoWS>> productosPorCategoria = carrito.ObtenerProductosPorCategoriaConStockBajo(stockLimite);

            dataGridViewProductosCriticos.Rows.Clear();

            foreach (var categoria in productosPorCategoria)
            {
                int categoriaId = categoria.Key;

                foreach (var producto in categoria.Value)
                {
                    dataGridViewProductosCriticos.Rows.Add(categoriaId, producto.Nombre, producto.Stock);
                }
            }
        }

        private void btncargarlista_Click(object sender, EventArgs e)
        {
            CargarProductosCriticos(10);
        }
    }

}


