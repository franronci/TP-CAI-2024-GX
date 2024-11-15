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
using System.IO;

namespace TemplateTPIntegrador.Reportes
{
    public partial class ProductomasvendidoCategoria : Form
    {
        public ProductomasvendidoCategoria()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }
        public class ProductoVentaInfo
        {
            public int CantidadVentas { get; set; }
            public List<int> IdsVentas { get; set; }

            public ProductoVentaInfo()
            {
                CantidadVentas = 0;
                IdsVentas = new List<int>();
            }
        }

        private void CargarDatosProductosMasVendidos()
        {
            ActualizarDataGridViewProductosMasVendidos();
        }
        private void ActualizarDataGridViewProductosMasVendidos()
        {
            // Ruta del archivo CSV
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Grupo3");
            string filePath = Path.Combine(directoryPath, "ventas.csv");

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo ventas.csv no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, Dictionary<string, ProductoVentaInfo>> productosMasVendidosPorCategoria =
                new Dictionary<string, Dictionary<string, ProductoVentaInfo>>();

            try
            {
                // Leer todas las líneas del archivo CSV excepto la primera (encabezados)
                string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 9)
                    {
                        string productosString = data[4].Trim();
                        string categoriasString = data[5].Trim();
                        string cantidadString = data[6].Trim();
                        string estadoString = data[8].Trim();

                        if (int.TryParse(estadoString, out int estado) && estado == 1)
                        {

                            string[] productos = productosString.Split('|').Select(p => p.Trim()).ToArray();
                            string[] categorias = categoriasString.Split('|').Select(c => c.Trim()).ToArray();
                            string[] cantidades = cantidadString.Split('|').Select(c => c.Trim()).ToArray();

                            if (productos.Length == categorias.Length && productos.Length == cantidades.Length)
                            {
                                for (int i = 0; i < productos.Length; i++)
                                {
                                    string producto = productos[i];
                                    string categoria = categorias[i];
                                    int cantidad = int.Parse(cantidades[i]);

                                    if (!productosMasVendidosPorCategoria.ContainsKey(categoria))
                                    {
                                        productosMasVendidosPorCategoria[categoria] = new Dictionary<string, ProductoVentaInfo>();
                                    }

                                    if (!productosMasVendidosPorCategoria[categoria].ContainsKey(producto))
                                    {
                                        productosMasVendidosPorCategoria[categoria][producto] = new ProductoVentaInfo();
                                    }

                                    productosMasVendidosPorCategoria[categoria][producto].CantidadVentas += cantidad;
                                    productosMasVendidosPorCategoria[categoria][producto].IdsVentas.Add(int.Parse(data[0].Trim()));
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Error en la estructura de datos de la línea: {line}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Línea incompleta o mal formada: {line}");
                    }
                }

                MostrarProductosMasVendidosEnDataGridView(productosMasVendidosPorCategoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarProductosMasVendidosEnDataGridView(Dictionary<string, Dictionary<string, ProductoVentaInfo>> productosMasVendidosPorCategoria)
        {
            // Crear un DataTable para mostrar los resultados
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Categoría");
            dataTable.Columns.Add("Producto");
            dataTable.Columns.Add("Cantidad", typeof(int));
            dataTable.Columns.Add("ID Venta", typeof(string));

            // Llenar el DataTable con los datos del diccionario
            foreach (var kvpCategoria in productosMasVendidosPorCategoria)
            {
                string categoria = kvpCategoria.Key;
                foreach (var kvpProducto in kvpCategoria.Value.OrderByDescending(x => x.Value.CantidadVentas))
                {
                    string producto = kvpProducto.Key;
                    int cantidadVentas = kvpProducto.Value.CantidadVentas;
                    string idsVentas = string.Join(", ", kvpProducto.Value.IdsVentas);

                    dataTable.Rows.Add(categoria, producto, cantidadVentas, idsVentas);
                }
            }

            // Asignar el DataTable al DataGridView si MasVendidosPorCategoria está inicializado
            if (MasVendidosPorCategoria != null)
            {
                MasVendidosPorCategoria.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("El DataGridView 'MasVendidosPorCategoria' no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú anterior?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void MasVendidosPorCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú anterior?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ProductomasvendidoCategoria_Load(object sender, EventArgs e)
        {
            CargarDatosProductosMasVendidos();
        }
    }
}
