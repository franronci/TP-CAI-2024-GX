using Datos;

namespace TemplateTPIntegrador.Reportes
{
    partial class VentasVendedor
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


        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncargar = new System.Windows.Forms.Button();
            this.txtdnivendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(12, 23);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 2;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // txtdnivendedor
            // 
            this.txtdnivendedor.Location = new System.Drawing.Point(118, 23);
            this.txtdnivendedor.Name = "txtdnivendedor";
            this.txtdnivendedor.Size = new System.Drawing.Size(100, 20);
            this.txtdnivendedor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dni vendedor";
            // 
            // VentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdnivendedor);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VentasVendedor";
            this.Text = "VentasVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.TextBox txtdnivendedor;
        private System.Windows.Forms.Label label1;
    }
}