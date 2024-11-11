namespace TemplateTPIntegrador.Productos
{
    partial class BajaProductos
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
            this.txtbajaProducto = new System.Windows.Forms.TextBox();
            this.btnbajaProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baja producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // txtbajaProducto
            // 
            this.txtbajaProducto.Location = new System.Drawing.Point(129, 177);
            this.txtbajaProducto.Name = "txtbajaProducto";
            this.txtbajaProducto.Size = new System.Drawing.Size(100, 20);
            this.txtbajaProducto.TabIndex = 2;
            // 
            // btnbajaProducto
            // 
            this.btnbajaProducto.Location = new System.Drawing.Point(129, 262);
            this.btnbajaProducto.Name = "btnbajaProducto";
            this.btnbajaProducto.Size = new System.Drawing.Size(100, 23);
            this.btnbajaProducto.TabIndex = 3;
            this.btnbajaProducto.Text = "Aceptar";
            this.btnbajaProducto.UseVisualStyleBackColor = true;
            this.btnbajaProducto.Click += new System.EventHandler(this.btnbajaProducto_Click);
            // 
            // BajaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.btnbajaProducto);
            this.Controls.Add(this.txtbajaProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BajaProductos";
            this.Text = "BajaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbajaProducto;
        private System.Windows.Forms.Button btnbajaProducto;
    }
}