namespace TemplateTPIntegrador.Reportes
{
    partial class ProductomasvendidoCategoria
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
            this.PmasVendido_label = new System.Windows.Forms.Label();
            this.MasVendidosPorCategoria = new System.Windows.Forms.DataGridView();
            this.Boton_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MasVendidosPorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // PmasVendido_label
            // 
            this.PmasVendido_label.AutoSize = true;
            this.PmasVendido_label.BackColor = System.Drawing.SystemColors.Info;
            this.PmasVendido_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PmasVendido_label.Location = new System.Drawing.Point(103, 27);
            this.PmasVendido_label.Name = "PmasVendido_label";
            this.PmasVendido_label.Size = new System.Drawing.Size(591, 39);
            this.PmasVendido_label.TabIndex = 0;
            this.PmasVendido_label.Text = "Producto mas vendidos por categoria";
            // 
            // MasVendidosPorCategoria
            // 
            this.MasVendidosPorCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasVendidosPorCategoria.Location = new System.Drawing.Point(26, 82);
            this.MasVendidosPorCategoria.Name = "MasVendidosPorCategoria";
            this.MasVendidosPorCategoria.Size = new System.Drawing.Size(741, 315);
            this.MasVendidosPorCategoria.TabIndex = 1;
            this.MasVendidosPorCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MasVendidosPorCategoria_CellContentClick);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(692, 425);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(75, 29);
            this.Boton_Salir.TabIndex = 2;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // ProductomasvendidoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.MasVendidosPorCategoria);
            this.Controls.Add(this.PmasVendido_label);
            this.Name = "ProductomasvendidoCategoria";
            this.Text = "Reporte: Producto mas vendido por Categoria";
            this.Load += new System.EventHandler(this.ProductomasvendidoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasVendidosPorCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PmasVendido_label;
        private System.Windows.Forms.DataGridView MasVendidosPorCategoria;
        private System.Windows.Forms.Button Boton_Salir;
    }
}