﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Datos;
using Negocio;

namespace TemplateTPIntegrador.Productos
{
    public partial class AgregarProducto : Form
    {
        private Negocio.Proveedor ProveedorNegocio = new Negocio.Proveedor();
        public AgregarProducto()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;

            // Configurar para la categoría de producto
            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Categoria.Items.Add("Audio");
            ComboBox_Categoria.Items.Add("Celulares");
            ComboBox_Categoria.Items.Add("ElectroHogar");
            ComboBox_Categoria.Items.Add("Informática");
            ComboBox_Categoria.Items.Add("Smart TV");
            ComboBox_Categoria.SelectedIndex = -1; // Establecer el combobox de categoría en vacío por defecto

            List<DatosProveedorWS> Proveedor = ProveedorNegocio.listarProveedores();

            if (Proveedor != null)
            {
                Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.FechaBaja == null).ToList();
            }

            ComboBox_Proveedor.DataSource = Proveedor;
            ComboBox_Proveedor.DisplayMember = "nombre";
            ComboBox_Proveedor.ValueMember = "id";
            ComboBox_Proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Proveedor.SelectedIndex = -1; // Establecer el combobox de proveedor en vacío por defecto
        }
        private int SeleccionarCategoría()
        {
            int idCategoria;
            if (ComboBox_Categoria.SelectedIndex != -1) // Verifica si se ha seleccionado un ítem en el ComboBox
            {

                if (ComboBox_Categoria.SelectedItem.ToString() == "Audio")
                {
                    idCategoria = 1;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "Celulares")
                {
                    idCategoria = 2;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "ElectroHogar")
                {
                    idCategoria = 3;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "Informática")
                {
                    idCategoria = 4;
                }
                else
                {
                    idCategoria = 5;
                }
            }
            else
            {
                // En caso de que no se haya seleccionado ningún ítem en el ComboBox
                MessageBox.Show("Por favor, seleccione un tipo de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Categoria.Focus();
                return 0; // Sale del método sin continuar la validación
            }
            return idCategoria;
        }
        private void CrearProducto()
        {
            int idCategoria = SeleccionarCategoría();

            DatosProveedorWS selectedProveedor = (DatosProveedorWS)ComboBox_Proveedor.SelectedItem;
            Guid IdProveedor = selectedProveedor.Id;
            string IdProveedor1 = IdProveedor.ToString();



            // Crear un nuevo producto con los datos del formulario
            Negocio.Producto Producto = new Negocio.Producto();
            Producto.AgregarProductos(
                                            idCategoria,
                                            "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
                                            IdProveedor1,
                                            Box_Nombre.Text,
                                            int.Parse(Box_Precio.Text),
                                            int.Parse(Box_Stock.Text)
                                         );
        }
        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            if (ComboBox_Proveedor.SelectedIndex == -1)
            {
                Proveedor_Error.Visible = true;
                MessageBox.Show("No se seleccionó un proveedor.\n\nPor favor, seleccione proveedor y vuelva a intentarlo.", "Revisar el Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Proveedor.Focus();
                ContarErrores++;
            }

            if (ComboBox_Categoria.SelectedIndex == -1)
            {
                Categoria_Error.Visible = true;

                // Mostrar mensaje de advertencia cuando el tipo de categoría está en blanco
                MessageBox.Show("No se seleccionó ningún tipo de Categoria.\n\nPor favor, seleccione un tipo de Categoria y vuelva a intentarlo.", "Revisar la Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Categoria.Focus();
                MayudaCategoria.Visible = true;
                ContarErrores++;
            }
            else
            {
                Categoria_Error.Visible = false;
                MayudaCategoria.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorNombre = ValidacionesDeNegocio.ValidarVacio(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Revisar el Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaNombre.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorPrecio = ValidacionesDeNegocio.EsPrecio(Box_Precio.Text, "Precio");
            if (errorPrecio != null)
            {
                Precio_Error.Text = errorPrecio;
                Precio_Error.Visible = true;
                MessageBox.Show(errorPrecio, "Revisar el Precio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContarErrores++;
            }
            else
            {
                Precio_Error.Visible = false;
                MayudaPrecio.Visible = false;
            }
            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorStock = ValidacionesDeNegocio.EsStock(Box_Stock.Text, "Stock");
            if (errorStock != null)
            {
                Stock_Error.Text = errorStock;
                Stock_Error.Visible = true;
                MessageBox.Show(errorStock, "Revisar el Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContarErrores++;
            }
            else
            {
                Stock_Error.Visible = false;
                MayudaStock.Visible = false;
            }
            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }
            return ContarErrores;
        }
        private void Limpiar()
        {
            ComboBox_Categoria.SelectedIndex = -1;
            ComboBox_Proveedor.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Precio.Text = "";
            Box_Stock.Text = "";

            Categoria_Error.Visible = false;
            Nombre_Error.Visible = false;
            Stock_Error.Visible = false;
            Precio_Error.Visible = false;

            MayudaCategoria.Visible = false;
            MayudaNombre.Visible = false;
            MayudaPrecio.Visible = false;
            MayudaStock.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarProducto_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearProducto();

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el producto {Box_Nombre.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show($"Se ha realizado la operación de alta para el producto {Box_Nombre.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea seguir cargando productos?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        ListarProductos ListaProductos = new ListarProductos();
                        ListaProductos.Show();
                    }
                    else
                    {
                        Limpiar(); // Restablecer todos los campos del formulario
                    }
                }
            }
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea borrar todos los campos?\n\nSe perderán todos los cambios.", "Confirmar Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al listado de productos?. Los cambios no se guardarán", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                
            }
        }

        private void MayudaNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
