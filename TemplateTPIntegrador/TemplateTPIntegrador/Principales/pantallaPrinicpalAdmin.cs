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
using TemplateTPIntegrador.Productos;
using TemplateTPIntegrador.Proveedor;
using TemplateTPIntegrador.Reportes;

namespace TemplateTPIntegrador
{
    public partial class pantallaPrinicpalAdmin : Form
    {
        public pantallaPrinicpalAdmin()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            CreacionUsuario formCreacionUsuario = new CreacionUsuario();
            formCreacionUsuario.ShowDialog();
        }

        private void btnbajausuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario formeliminarUsuario = new EliminarUsuario();
            formeliminarUsuario.ShowDialog();

        }

        private void btnActivarusuario_Click(object sender, EventArgs e)
        {
            ActivarUsuario formactivarUsuario = new ActivarUsuario();

            formactivarUsuario.ShowDialog();

        }

        private void btnaltaProveedor_Click(object sender, EventArgs e)
        {
            AltaProveedorf fromaaltaProveedor = new AltaProveedorf();

            fromaaltaProveedor.ShowDialog();
        }

        private void btnbajaProveedor_Click(object sender, EventArgs e)
        {
            ListaProveedores formabajaProveedor = new ListaProveedores();

            formabajaProveedor.ShowDialog();
        }

        private void btnmodificarproveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnaltaProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto formagregarProducto = new AgregarProducto();

            formagregarProducto.ShowDialog();
        }

        private void btnbajaProducto_Click(object sender, EventArgs e)
        {
            ListarProductos formmodificarProductos = new ListarProductos();

            formmodificarProductos.ShowDialog();
        }

        private void btnmodificarProducto_Click(object sender, EventArgs e)
        {
  
        }

        private void btnproductoXCategoria_Click(object sender, EventArgs e)
        {
            ProductomasvendidoCategoria formmprodumasvendido = new ProductomasvendidoCategoria();

            formmprodumasvendido.ShowDialog();
        }

        private void btnstockCritico_Click(object sender, EventArgs e)
        {
            ProductosCriticos formproductosCriticos = new ProductosCriticos();
            

            formproductosCriticos.ShowDialog();
        }

        private void btnventasXVendedor_Click(object sender, EventArgs e)
        {
            VentasVendedor venta = new VentasVendedor();

            venta.ShowDialog();
        }
    }
}
