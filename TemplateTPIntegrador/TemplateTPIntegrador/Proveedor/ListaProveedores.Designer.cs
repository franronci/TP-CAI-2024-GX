
namespace TemplateTPIntegrador.Proveedor
{
    partial class ListaProveedores
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
            this.BuscarProveedor_Label = new System.Windows.Forms.Label();
            this.BuscarPorCUIT_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Proveedores = new System.Windows.Forms.DataGridView();
            this.BotonAltaProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarProveedor_Label
            // 
            this.BuscarProveedor_Label.AutoSize = true;
            this.BuscarProveedor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProveedor_Label.Location = new System.Drawing.Point(12, 30);
            this.BuscarProveedor_Label.Name = "BuscarProveedor_Label";
            this.BuscarProveedor_Label.Size = new System.Drawing.Size(206, 29);
            this.BuscarProveedor_Label.TabIndex = 0;
            this.BuscarProveedor_Label.Text = "Buscar Proveedor";
            // 
            // BuscarPorCUIT_Label
            // 
            this.BuscarPorCUIT_Label.AutoSize = true;
            this.BuscarPorCUIT_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorCUIT_Label.Location = new System.Drawing.Point(450, 30);
            this.BuscarPorCUIT_Label.Name = "BuscarPorCUIT_Label";
            this.BuscarPorCUIT_Label.Size = new System.Drawing.Size(191, 29);
            this.BuscarPorCUIT_Label.TabIndex = 1;
            this.BuscarPorCUIT_Label.Text = "Buscar por CUIT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(647, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources._64673;
            this.pictureBox1.Location = new System.Drawing.Point(383, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TemplateTPIntegrador.Properties.Resources._64673;
            this.pictureBox2.Location = new System.Drawing.Point(797, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Proveedores
            // 
            this.Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Proveedores.Location = new System.Drawing.Point(17, 84);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(951, 408);
            this.Proveedores.TabIndex = 6;
            // 
            // BotonAltaProveedores
            // 
            this.BotonAltaProveedores.Location = new System.Drawing.Point(878, 23);
            this.BotonAltaProveedores.Name = "BotonAltaProveedores";
            this.BotonAltaProveedores.Size = new System.Drawing.Size(90, 36);
            this.BotonAltaProveedores.TabIndex = 7;
            this.BotonAltaProveedores.Text = "Crear";
            this.BotonAltaProveedores.UseVisualStyleBackColor = true;
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 526);
            this.Controls.Add(this.BotonAltaProveedores);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuscarPorCUIT_Label);
            this.Controls.Add(this.BuscarProveedor_Label);
            this.Name = "ListaProveedores";
            this.Text = "ListaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscarProveedor_Label;
        private System.Windows.Forms.Label BuscarPorCUIT_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Proveedores;
        private System.Windows.Forms.Button BotonAltaProveedores;
    }
}