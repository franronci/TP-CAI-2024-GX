
namespace TemplateTPIntegrador.Productos
{
    partial class ListarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuscarProducto_Label = new System.Windows.Forms.Label();
            this.ProductoBuscador = new System.Windows.Forms.TextBox();
            this.ProductosLupa = new System.Windows.Forms.PictureBox();
            this.FiltrarPorCategoria_Label = new System.Windows.Forms.Label();
            this.Boton_AltaProducto = new System.Windows.Forms.Button();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.Productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarProducto_Label
            // 
            this.BuscarProducto_Label.AutoSize = true;
            this.BuscarProducto_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProducto_Label.Location = new System.Drawing.Point(25, 26);
            this.BuscarProducto_Label.Name = "BuscarProducto_Label";
            this.BuscarProducto_Label.Size = new System.Drawing.Size(190, 29);
            this.BuscarProducto_Label.TabIndex = 0;
            this.BuscarProducto_Label.Text = "Buscar Producto";
            // 
            // ProductoBuscador
            // 
            this.ProductoBuscador.Location = new System.Drawing.Point(221, 35);
            this.ProductoBuscador.Name = "ProductoBuscador";
            this.ProductoBuscador.Size = new System.Drawing.Size(144, 20);
            this.ProductoBuscador.TabIndex = 3;
            this.ProductoBuscador.TextChanged += new System.EventHandler(this.ProductoBuscador_TextChanged);
            // 
            // ProductosLupa
            // 
            this.ProductosLupa.BackColor = System.Drawing.Color.White;
            this.ProductosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductosLupa.Image = global::TemplateTPIntegrador.Properties.Resources._64673;
            this.ProductosLupa.Location = new System.Drawing.Point(375, 26);
            this.ProductosLupa.Name = "ProductosLupa";
            this.ProductosLupa.Size = new System.Drawing.Size(33, 29);
            this.ProductosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductosLupa.TabIndex = 5;
            this.ProductosLupa.TabStop = false;
            this.ProductosLupa.Click += new System.EventHandler(this.ProductosLupa_Click);
            // 
            // FiltrarPorCategoria_Label
            // 
            this.FiltrarPorCategoria_Label.AutoSize = true;
            this.FiltrarPorCategoria_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarPorCategoria_Label.Location = new System.Drawing.Point(414, 26);
            this.FiltrarPorCategoria_Label.Name = "FiltrarPorCategoria_Label";
            this.FiltrarPorCategoria_Label.Size = new System.Drawing.Size(228, 29);
            this.FiltrarPorCategoria_Label.TabIndex = 6;
            this.FiltrarPorCategoria_Label.Text = "Filtrar por Categoria";
            // 
            // Boton_AltaProducto
            // 
            this.Boton_AltaProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Boton_AltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaProducto.Location = new System.Drawing.Point(883, 26);
            this.Boton_AltaProducto.Name = "Boton_AltaProducto";
            this.Boton_AltaProducto.Size = new System.Drawing.Size(90, 36);
            this.Boton_AltaProducto.TabIndex = 9;
            this.Boton_AltaProducto.Text = "Crear";
            this.Boton_AltaProducto.UseVisualStyleBackColor = false;
            this.Boton_AltaProducto.Click += new System.EventHandler(this.Boton_AltaProducto_Click);
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(30, 520);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(128, 37);
            this.BorrarFiltro.TabIndex = 11;
            this.BorrarFiltro.Text = "Borrar Filtro";
            this.BorrarFiltro.UseVisualStyleBackColor = true;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Boton_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Modificar.Location = new System.Drawing.Point(335, 520);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(128, 37);
            this.Boton_Modificar.TabIndex = 12;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Eliminar.Location = new System.Drawing.Point(495, 520);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(128, 37);
            this.Boton_Eliminar.TabIndex = 13;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(845, 520);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(128, 37);
            this.Boton_Salir.TabIndex = 14;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(648, 34);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(144, 21);
            this.ComboBox_Categoria.TabIndex = 15;
            this.ComboBox_Categoria.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Categoria_SelectedIndexChanged);
            // 
            // Productos
            // 
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Location = new System.Drawing.Point(30, 77);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(943, 421);
            this.Productos.TabIndex = 16;
            this.Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            // 
            // ListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 577);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.Boton_AltaProducto);
            this.Controls.Add(this.FiltrarPorCategoria_Label);
            this.Controls.Add(this.ProductosLupa);
            this.Controls.Add(this.ProductoBuscador);
            this.Controls.Add(this.BuscarProducto_Label);
            this.Name = "ListarProductos";
            this.Text = "Listar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductosLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscarProducto_Label;
        private System.Windows.Forms.TextBox ProductoBuscador;
        private System.Windows.Forms.PictureBox ProductosLupa;
        private System.Windows.Forms.Label FiltrarPorCategoria_Label;
        private System.Windows.Forms.Button Boton_AltaProducto;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.DataGridView Productos;
    }
}