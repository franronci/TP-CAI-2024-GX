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
    public partial class VentasVendedor : Form
    {
        public VentasVendedor()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configurar DataGridView al inicio
        }
        private void VentasVendedor_load(object sender, EventArgs e)
        {

            int dni_int = int.Parse(txtdnivendedor.Text);
            CargarVentasAgrupadas(dni_int);
        }


        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MesAnio", "Mes y Año");
            dataGridView1.Columns.Add("CantidadVentas", "Cantidad de Ventas");
            dataGridView1.Columns.Add("MontoTotal", "Monto Total de Ventas");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }


        private void CargarVentasAgrupadas(int dnivendedor)
        {
            Carrito carrito = new Carrito();
            Administrador administrador = new Administrador();

            string idVendedor = administrador.traeridcondni(dnivendedor); 
            Console.Write(idVendedor);
            Console.WriteLine("HOOLA");
            
 
            List<VentaAgrupada> ventasAgrupadas = carrito.ObtenerVentasPorUsuario(idVendedor);

            dataGridView1.Rows.Clear();


            foreach (var venta in ventasAgrupadas)
            {
                dataGridView1.Rows.Add(venta.MesAnio, venta.CantidadVentas, venta.MontoTotal);
                Console.WriteLine($"{venta.MesAnio}, {venta.CantidadVentas}, {venta.MontoTotal}");
            }

            foreach (var venta in ventasAgrupadas)
            {
                Console.WriteLine($"Mes/Año: {venta.MesAnio}, Cantidad de Ventas: {venta.CantidadVentas}, Monto Total: {venta.MontoTotal:C}");
            }
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            int dni_int = int.Parse(txtdnivendedor.Text);
            CargarVentasAgrupadas(dni_int);
        }
    }
}

