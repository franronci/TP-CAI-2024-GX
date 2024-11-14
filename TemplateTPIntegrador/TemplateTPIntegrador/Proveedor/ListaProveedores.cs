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

namespace TemplateTPIntegrador.Proveedor
{
    public partial class ListaProveedores : Form
    {
        Negocio.Proveedor ProveedorNegocio = new Negocio.Proveedor();
        public ListaProveedores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void CargarProveedores()
        {
            try
            {
                List<DatosProveedorWS> Proveedor = ProveedorNegocio.listarProveedores();

                if (Proveedor != null)
                {
                    Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.Email.Contains("@G1")).ToList();
                }

                var bindingList = new BindingList<DatosProveedorWS>(Proveedor);
                var source = new BindingSource(bindingList, null);
                Proveedores.DataSource = source;
                Proveedores.Columns["ID"].Visible = false;
                Proveedores.Columns["fechaBaja"].Visible = false;
                Proveedores.Columns["fechaAlta"].HeaderText = "Fecha de Alta";


                foreach (DataGridViewRow row in Proveedores.Rows)
                {
                    if (row.Cells["fechaAlta"].Value != null && row.Cells["fechaAlta"].Value.ToString() == "0001-01-01T00:00:00")
                    {
                        row.Cells["fechaAlta"].Value = DateTime.Today.ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Proveedores: " + ex.Message);
            }
        }
    }
}
