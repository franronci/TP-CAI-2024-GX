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
    public partial class DevolverVenta : Form
    {
        private void btnusuarioeliminar_Click(object sender, EventArgs e)
        {
            Negocio.Venta venta = new Negocio.Venta();

            Guid id_Sesion =Guid.Parse( SesionUsuario.IdUsuario);

            Guid id_venta = Guid.Parse(ventadevolver.Text);

            MessageBox.Show( venta.devolverVenta(id_venta, id_Sesion));
        }
    }
}
