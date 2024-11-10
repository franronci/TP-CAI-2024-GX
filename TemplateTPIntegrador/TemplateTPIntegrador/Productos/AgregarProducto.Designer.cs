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
            this.btnagregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtnombreProducto = new System.Windows.Forms.TextBox();
            this.numberStock = new System.Windows.Forms.NumericUpDown();
            this.numeroprecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroprecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregarProducto
            // 
            this.btnagregarProducto.Location = new System.Drawing.Point(48, 328);
            this.btnagregarProducto.Name = "btnagregarProducto";
            this.btnagregarProducto.Size = new System.Drawing.Size(100, 23);
            this.btnagregarProducto.TabIndex = 0;
            this.btnagregarProducto.Text = "Agregar";
            this.btnagregarProducto.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(45, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(48, 133);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 6;
            // 
            // txtnombreProducto
            // 
            this.txtnombreProducto.Location = new System.Drawing.Point(233, 133);
            this.txtnombreProducto.Name = "txtnombreProducto";
            this.txtnombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtnombreProducto.TabIndex = 7;
            // 
            // numberStock
            // 
            this.numberStock.Location = new System.Drawing.Point(233, 235);
            this.numberStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberStock.Name = "numberStock";
            this.numberStock.Size = new System.Drawing.Size(120, 20);
            this.numberStock.TabIndex = 10;
            // 
            // numeroprecio
            // 
            this.numeroprecio.DecimalPlaces = 2;
            this.numeroprecio.Location = new System.Drawing.Point(48, 235);
            this.numeroprecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeroprecio.Name = "numeroprecio";
            this.numeroprecio.Size = new System.Drawing.Size(120, 20);
            this.numeroprecio.TabIndex = 11;
            this.numeroprecio.ThousandsSeparator = true;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.numeroprecio);
            this.Controls.Add(this.numberStock);
            this.Controls.Add(this.txtnombreProducto);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnagregarProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numberStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroprecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtnombreProducto;
        private System.Windows.Forms.NumericUpDown numberStock;
        private System.Windows.Forms.NumericUpDown numeroprecio;
    }
}