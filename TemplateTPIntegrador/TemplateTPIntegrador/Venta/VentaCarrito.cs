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

namespace TemplateTPIntegrador.Venta
{
    public partial class VentaCarrito : Form
    {
        public VentaCarrito()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

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
    }
}
