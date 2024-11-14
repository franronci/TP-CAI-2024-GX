namespace TemplateTPIntegrador.Productos
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Box_Nombre = new System.Windows.Forms.TextBox();
            this.Proveedor_Label = new System.Windows.Forms.Label();
            this.Boton_Limpiar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.ComboBox_Proveedor = new System.Windows.Forms.ComboBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.Proveedor_Error = new System.Windows.Forms.TextBox();
            this.Categoria_Error = new System.Windows.Forms.TextBox();
            this.Nombre_Error = new System.Windows.Forms.TextBox();
            this.Precio_Error = new System.Windows.Forms.TextBox();
            this.Stock_Error = new System.Windows.Forms.TextBox();
            this.MayudaCategoria = new System.Windows.Forms.Label();
            this.MayudaNombre = new System.Windows.Forms.Label();
            this.MayudaPrecio = new System.Windows.Forms.Label();
            this.MayudaStock = new System.Windows.Forms.Label();
            this.Box_Precio = new System.Windows.Forms.TextBox();
            this.Box_Stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Agregar.Location = new System.Drawing.Point(23, 410);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(100, 23);
            this.Boton_Agregar.TabIndex = 0;
            this.Boton_Agregar.Text = "Agregar";
            this.Boton_Agregar.UseVisualStyleBackColor = false;
            this.Boton_Agregar.Click += new System.EventHandler(this.btnagregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.Location = new System.Drawing.Point(161, 170);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(120, 20);
            this.Box_Nombre.TabIndex = 7;
            // 
            // Proveedor_Label
            // 
            this.Proveedor_Label.AutoSize = true;
            this.Proveedor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor_Label.Location = new System.Drawing.Point(45, 61);
            this.Proveedor_Label.Name = "Proveedor_Label";
            this.Proveedor_Label.Size = new System.Drawing.Size(81, 20);
            this.Proveedor_Label.TabIndex = 12;
            this.Proveedor_Label.Text = "Proveedor";
            // 
            // Boton_Limpiar
            // 
            this.Boton_Limpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Boton_Limpiar.Location = new System.Drawing.Point(138, 410);
            this.Boton_Limpiar.Name = "Boton_Limpiar";
            this.Boton_Limpiar.Size = new System.Drawing.Size(100, 23);
            this.Boton_Limpiar.TabIndex = 14;
            this.Boton_Limpiar.Text = "Limpiar";
            this.Boton_Limpiar.UseVisualStyleBackColor = false;
            this.Boton_Limpiar.Click += new System.EventHandler(this.Boton_Limpiar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Boton_Cancelar.Location = new System.Drawing.Point(256, 410);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.Boton_Cancelar.TabIndex = 15;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // ComboBox_Proveedor
            // 
            this.ComboBox_Proveedor.FormattingEnabled = true;
            this.ComboBox_Proveedor.Location = new System.Drawing.Point(161, 59);
            this.ComboBox_Proveedor.Name = "ComboBox_Proveedor";
            this.ComboBox_Proveedor.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Proveedor.TabIndex = 16;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(160, 115);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Categoria.TabIndex = 17;
            // 
            // Proveedor_Error
            // 
            this.Proveedor_Error.BackColor = System.Drawing.SystemColors.Control;
            this.Proveedor_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Proveedor_Error.Location = new System.Drawing.Point(49, 85);
            this.Proveedor_Error.Name = "Proveedor_Error";
            this.Proveedor_Error.Size = new System.Drawing.Size(232, 13);
            this.Proveedor_Error.TabIndex = 18;
            // 
            // Categoria_Error
            // 
            this.Categoria_Error.BackColor = System.Drawing.SystemColors.Control;
            this.Categoria_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Categoria_Error.Location = new System.Drawing.Point(49, 144);
            this.Categoria_Error.Name = "Categoria_Error";
            this.Categoria_Error.Size = new System.Drawing.Size(232, 13);
            this.Categoria_Error.TabIndex = 19;
            // 
            // Nombre_Error
            // 
            this.Nombre_Error.BackColor = System.Drawing.SystemColors.Control;
            this.Nombre_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_Error.Location = new System.Drawing.Point(49, 203);
            this.Nombre_Error.Name = "Nombre_Error";
            this.Nombre_Error.Size = new System.Drawing.Size(232, 13);
            this.Nombre_Error.TabIndex = 20;
            // 
            // Precio_Error
            // 
            this.Precio_Error.BackColor = System.Drawing.SystemColors.Control;
            this.Precio_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precio_Error.Location = new System.Drawing.Point(51, 263);
            this.Precio_Error.Name = "Precio_Error";
            this.Precio_Error.Size = new System.Drawing.Size(232, 13);
            this.Precio_Error.TabIndex = 21;
            // 
            // Stock_Error
            // 
            this.Stock_Error.BackColor = System.Drawing.SystemColors.Control;
            this.Stock_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock_Error.Location = new System.Drawing.Point(49, 315);
            this.Stock_Error.Name = "Stock_Error";
            this.Stock_Error.Size = new System.Drawing.Size(232, 13);
            this.Stock_Error.TabIndex = 22;
            // 
            // MayudaCategoria
            // 
            this.MayudaCategoria.AutoSize = true;
            this.MayudaCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MayudaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaCategoria.Location = new System.Drawing.Point(286, 116);
            this.MayudaCategoria.Name = "MayudaCategoria";
            this.MayudaCategoria.Size = new System.Drawing.Size(18, 20);
            this.MayudaCategoria.TabIndex = 23;
            this.MayudaCategoria.Text = "?";
            // 
            // MayudaNombre
            // 
            this.MayudaNombre.AutoSize = true;
            this.MayudaNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MayudaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaNombre.Location = new System.Drawing.Point(286, 170);
            this.MayudaNombre.Name = "MayudaNombre";
            this.MayudaNombre.Size = new System.Drawing.Size(18, 20);
            this.MayudaNombre.TabIndex = 24;
            this.MayudaNombre.Text = "?";
            // 
            // MayudaPrecio
            // 
            this.MayudaPrecio.AutoSize = true;
            this.MayudaPrecio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MayudaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaPrecio.Location = new System.Drawing.Point(286, 229);
            this.MayudaPrecio.Name = "MayudaPrecio";
            this.MayudaPrecio.Size = new System.Drawing.Size(18, 20);
            this.MayudaPrecio.TabIndex = 25;
            this.MayudaPrecio.Text = "?";
            // 
            // MayudaStock
            // 
            this.MayudaStock.AutoSize = true;
            this.MayudaStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MayudaStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaStock.Location = new System.Drawing.Point(287, 289);
            this.MayudaStock.Name = "MayudaStock";
            this.MayudaStock.Size = new System.Drawing.Size(18, 20);
            this.MayudaStock.TabIndex = 26;
            this.MayudaStock.Text = "?";
            // 
            // Box_Precio
            // 
            this.Box_Precio.Location = new System.Drawing.Point(160, 231);
            this.Box_Precio.Name = "Box_Precio";
            this.Box_Precio.Size = new System.Drawing.Size(120, 20);
            this.Box_Precio.TabIndex = 27;
            // 
            // Box_Stock
            // 
            this.Box_Stock.Location = new System.Drawing.Point(160, 289);
            this.Box_Stock.Name = "Box_Stock";
            this.Box_Stock.Size = new System.Drawing.Size(120, 20);
            this.Box_Stock.TabIndex = 28;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 455);
            this.Controls.Add(this.Box_Stock);
            this.Controls.Add(this.Box_Precio);
            this.Controls.Add(this.MayudaStock);
            this.Controls.Add(this.MayudaPrecio);
            this.Controls.Add(this.MayudaNombre);
            this.Controls.Add(this.MayudaCategoria);
            this.Controls.Add(this.Stock_Error);
            this.Controls.Add(this.Precio_Error);
            this.Controls.Add(this.Nombre_Error);
            this.Controls.Add(this.Categoria_Error);
            this.Controls.Add(this.Proveedor_Error);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.ComboBox_Proveedor);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Limpiar);
            this.Controls.Add(this.Proveedor_Label);
            this.Controls.Add(this.Box_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.Label Proveedor_Label;
        private System.Windows.Forms.Button Boton_Limpiar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.ComboBox ComboBox_Proveedor;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.TextBox Proveedor_Error;
        private System.Windows.Forms.TextBox Categoria_Error;
        private System.Windows.Forms.TextBox Nombre_Error;
        private System.Windows.Forms.TextBox Precio_Error;
        private System.Windows.Forms.TextBox Stock_Error;
        private System.Windows.Forms.Label MayudaCategoria;
        private System.Windows.Forms.Label MayudaNombre;
        private System.Windows.Forms.Label MayudaPrecio;
        private System.Windows.Forms.Label MayudaStock;
        private System.Windows.Forms.TextBox Box_Precio;
        private System.Windows.Forms.TextBox Box_Stock;
    }
}