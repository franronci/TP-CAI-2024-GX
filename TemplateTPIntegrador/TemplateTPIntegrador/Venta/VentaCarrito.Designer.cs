namespace TemplateTPIntegrador.Venta
{
    partial class VentaCarrito
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdniclientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPreciounitario = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnagregarProductocarrito = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.datagridcarritocompra = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxProductosCategoria = new System.Windows.Forms.ComboBox();
            this.txtapellidoCliente = new System.Windows.Forms.TextBox();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmailcliente = new System.Windows.Forms.TextBox();
            this.btnagregarDNI = new System.Windows.Forms.Button();
            this.btnfinalizarCompra = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalConDescuento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarritocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // txtdniclientes
            // 
            this.txtdniclientes.Location = new System.Drawing.Point(55, 135);
            this.txtdniclientes.Name = "txtdniclientes";
            this.txtdniclientes.Size = new System.Drawing.Size(100, 20);
            this.txtdniclientes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Precio unitario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total";
            // 
            // boxCategoria
            // 
            this.boxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.boxCategoria.Location = new System.Drawing.Point(42, 272);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(49, 21);
            this.boxCategoria.TabIndex = 13;
            this.boxCategoria.SelectedIndexChanged += new System.EventHandler(this.boxCategoria_SelectedIndexChanged);
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(276, 274);
            this.numericCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(73, 20);
            this.numericCantidad.TabIndex = 15;
            this.numericCantidad.ValueChanged += new System.EventHandler(this.numericCantidad_ValueChanged);
            // 
            // txtPreciounitario
            // 
            this.txtPreciounitario.Location = new System.Drawing.Point(406, 272);
            this.txtPreciounitario.Name = "txtPreciounitario";
            this.txtPreciounitario.ReadOnly = true;
            this.txtPreciounitario.Size = new System.Drawing.Size(81, 20);
            this.txtPreciounitario.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(541, 272);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // btnagregarProductocarrito
            // 
            this.btnagregarProductocarrito.Location = new System.Drawing.Point(675, 272);
            this.btnagregarProductocarrito.Name = "btnagregarProductocarrito";
            this.btnagregarProductocarrito.Size = new System.Drawing.Size(113, 23);
            this.btnagregarProductocarrito.TabIndex = 18;
            this.btnagregarProductocarrito.Text = "Agregar";
            this.btnagregarProductocarrito.UseVisualStyleBackColor = true;
            this.btnagregarProductocarrito.Click += new System.EventHandler(this.btnagregarProductocarrito_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Carrito";
            // 
            // datagridcarritocompra
            // 
            this.datagridcarritocompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcarritocompra.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridcarritocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcarritocompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Producto,
            this.Cantidad,
            this.Precio_unitario,
            this.Total});
            this.datagridcarritocompra.Location = new System.Drawing.Point(45, 342);
            this.datagridcarritocompra.Name = "datagridcarritocompra";
            this.datagridcarritocompra.Size = new System.Drawing.Size(721, 234);
            this.datagridcarritocompra.TabIndex = 20;
            this.datagridcarritocompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // boxProductosCategoria
            // 
            this.boxProductosCategoria.FormattingEnabled = true;
            this.boxProductosCategoria.Location = new System.Drawing.Point(130, 274);
            this.boxProductosCategoria.Name = "boxProductosCategoria";
            this.boxProductosCategoria.Size = new System.Drawing.Size(121, 21);
            this.boxProductosCategoria.TabIndex = 21;
            this.boxProductosCategoria.Text = "Elija una categoria";
            this.boxProductosCategoria.SelectedIndexChanged += new System.EventHandler(this.boxProductosCategoria_SelectedIndexChanged);
            // 
            // txtapellidoCliente
            // 
            this.txtapellidoCliente.Location = new System.Drawing.Point(387, 135);
            this.txtapellidoCliente.Name = "txtapellidoCliente";
            this.txtapellidoCliente.ReadOnly = true;
            this.txtapellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtapellidoCliente.TabIndex = 22;
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Location = new System.Drawing.Point(222, 135);
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.ReadOnly = true;
            this.txtnombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtnombreCliente.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Apellido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(565, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mail";
            // 
            // txtmailcliente
            // 
            this.txtmailcliente.Location = new System.Drawing.Point(568, 135);
            this.txtmailcliente.Name = "txtmailcliente";
            this.txtmailcliente.ReadOnly = true;
            this.txtmailcliente.Size = new System.Drawing.Size(100, 20);
            this.txtmailcliente.TabIndex = 26;
            this.txtmailcliente.TextChanged += new System.EventHandler(this.txtmailcliente_TextChanged);
            // 
            // btnagregarDNI
            // 
            this.btnagregarDNI.Location = new System.Drawing.Point(55, 161);
            this.btnagregarDNI.Name = "btnagregarDNI";
            this.btnagregarDNI.Size = new System.Drawing.Size(64, 23);
            this.btnagregarDNI.TabIndex = 27;
            this.btnagregarDNI.Text = "Agregar";
            this.btnagregarDNI.UseVisualStyleBackColor = true;
            this.btnagregarDNI.Click += new System.EventHandler(this.btnagregarDNI_Click);
            // 
            // btnfinalizarCompra
            // 
            this.btnfinalizarCompra.Location = new System.Drawing.Point(675, 636);
            this.btnfinalizarCompra.Name = "btnfinalizarCompra";
            this.btnfinalizarCompra.Size = new System.Drawing.Size(113, 23);
            this.btnfinalizarCompra.TabIndex = 28;
            this.btnfinalizarCompra.Text = "Finalizar Compra";
            this.btnfinalizarCompra.UseVisualStyleBackColor = true;
            this.btnfinalizarCompra.Click += new System.EventHandler(this.btnfinalizarCompra_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 636);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total con descuentos";
            // 
            // txtTotalConDescuento
            // 
            this.txtTotalConDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConDescuento.Location = new System.Drawing.Point(328, 634);
            this.txtTotalConDescuento.Name = "txtTotalConDescuento";
            this.txtTotalConDescuento.ReadOnly = true;
            this.txtTotalConDescuento.Size = new System.Drawing.Size(100, 29);
            this.txtTotalConDescuento.TabIndex = 30;
            // 
            // VentaCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.txtTotalConDescuento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnfinalizarCompra);
            this.Controls.Add(this.btnagregarDNI);
            this.Controls.Add(this.txtmailcliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtnombreCliente);
            this.Controls.Add(this.txtapellidoCliente);
            this.Controls.Add(this.boxProductosCategoria);
            this.Controls.Add(this.datagridcarritocompra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnagregarProductocarrito);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPreciounitario);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.boxCategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdniclientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentaCarrito";
            this.Text = "VentaCarrito";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcarritocompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdniclientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox boxCategoria;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.TextBox txtPreciounitario;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnagregarProductocarrito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datagridcarritocompra;
        private System.Windows.Forms.ComboBox boxProductosCategoria;
        private System.Windows.Forms.TextBox txtapellidoCliente;
        private System.Windows.Forms.TextBox txtnombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmailcliente;
        private System.Windows.Forms.Button btnagregarDNI;
        private System.Windows.Forms.Button btnfinalizarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalConDescuento;
    }
}