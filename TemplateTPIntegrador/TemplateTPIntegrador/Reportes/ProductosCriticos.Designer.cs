namespace TemplateTPIntegrador.Reportes
{
    partial class ProductosCriticos
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btncarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 374);
            this.dataGridView2.TabIndex = 1;
            // 
            // btncarga
            // 
            this.btncarga.Location = new System.Drawing.Point(32, 26);
            this.btncarga.Name = "btncarga";
            this.btncarga.Size = new System.Drawing.Size(75, 23);
            this.btncarga.TabIndex = 2;
            this.btncarga.Text = "Cargar";
            this.btncarga.UseVisualStyleBackColor = true;
            this.btncarga.Click += new System.EventHandler(this.btncarga_Click);
            // 
            // ProductosCriticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncarga);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ProductosCriticos";
            this.Text = "ProductosCriticos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btncarga;
    }
}