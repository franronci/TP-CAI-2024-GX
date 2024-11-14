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
using Negocio;
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

        private void InterfazListaProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            try
            {
                List<DatosProveedorWS> Proveedor = ProveedorNegocio.listarProveedores();

                if (Proveedor != null)
                {
                    Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.Email.Contains("")).ToList();
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

        private void Listado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }




        private void Limpiar() // Blanquea campos de búsqueda
        {
            ProveedoresBuscador.Text = "";
            CUITBuscador.Text = "";
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }
  
        private void Boton_Modificar_Click(object sender, EventArgs e)
        {

        }
        private void EliminarProveedor(Guid idProveedor)
        {
            Negocio.Proveedor BajaProveedor = new Negocio.Proveedor();
            Guid idUsuario = Guid.Parse(SesionUsuario.IdUsuario);
            BajaProveedor.BorrarProveedor(idProveedor, idUsuario);
            CargarProveedores();
        }
        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {

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
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void ProveedoresLupa_Click_1(object sender, EventArgs e)
        {
            string textoBusqueda = ProveedoresBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProveedores();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            if (Proveedores.DataSource == null || Proveedores.Rows.Count == 0)
            {
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay usuarios para buscar.");
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }
            else
            {
                List<DatosProveedorWS> proveedoresFiltrados = new List<DatosProveedorWS>();

                foreach (DataGridViewRow fila in Proveedores.Rows)
                {
                    string nombreProveedor = fila.Cells["Nombre"].Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreProveedor) && nombreProveedor.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        proveedoresFiltrados.Add((DatosProveedorWS)fila.DataBoundItem);
                    }
                }

                if (proveedoresFiltrados.Count > 0)
                {
                    var bindingList = new BindingList<DatosProveedorWS>(proveedoresFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Proveedores.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                }
            }
        }

        private void CUITLupa_Click_1(object sender, EventArgs e)
        {
            string textoBusqueda = CUITBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProveedores();
            }

            if (Proveedores.DataSource == null || Proveedores.Rows.Count == 0)
            {
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay proveedores para buscar.");
            }
            else
            {
                List<DatosProveedorWS> proveedoresFiltrados = new List<DatosProveedorWS>();

                foreach (DataGridViewRow fila in Proveedores.Rows)
                {
                    string CUIT = fila.Cells["CUIT"].Value?.ToString();

                    if (!string.IsNullOrEmpty(CUIT) && CUIT.Contains(textoBusqueda))
                    {
                        proveedoresFiltrados.Add((DatosProveedorWS)fila.DataBoundItem);
                    }
                }

                if (proveedoresFiltrados.Count > 0)
                {
                    var bindingList = new BindingList<DatosProveedorWS>(proveedoresFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Proveedores.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                    Boton_Modificar.Visible = false;
                    Boton_Eliminar.Visible = false;
                }
            }
        }

        private void BotonAltaProveedores_Click_1(object sender, EventArgs e)
        {
            AltaProveedorf AltaProveedores = new AltaProveedorf();
            Hide();
            AltaProveedores.Show();
        }

        private void Boton_BorrarFiltro_Click_1(object sender, EventArgs e)
        {
            CargarProveedores();
            Limpiar();
        }

        private void Boton_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (Proveedores.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Proveedores.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idProveedor = filaSeleccionada.Cells["id"].Value.ToString();
                Guid idProveedor_guid = Guid.Parse(idProveedor);
                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Está seguro que desea eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    EliminarProveedor(idProveedor_guid);
                    MessageBox.Show("Se ha eliminado el Proveedor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                else
                {
                    MessageBox.Show("La eliminación del proveedor ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        }

        private void Boton_Salir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                pantallaPrinicpalAdmin ventanaMenu = new pantallaPrinicpalAdmin();
                ventanaMenu.Show();
            }
        }

        private void Boton_Modificar_Click_1(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (Proveedores.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Proveedores.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idProveedor = filaSeleccionada.Cells["id"].Value.ToString(); // Lo voy a reutilizar para el patch y el delete
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string CUIT = filaSeleccionada.Cells["CUIT"].Value.ToString();

                ModificarProveedorf ModificarProveedores = new ModificarProveedorf(idProveedor);
                ModificarProveedores.ActualizarTextBox(nombre, apellido, email, CUIT); // Levanto los datos de la lista y me los llevo a otra ventana.

                Hide();
                ModificarProveedores.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en Modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CUITBuscador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
