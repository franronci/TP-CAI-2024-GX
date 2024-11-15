namespace TemplateTPIntegrador.Reportes
{
    partial class ProductosCriticos
    {

        private System.ComponentModel.IContainer components = null;


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
            this.dataGridViewProductosCriticos = new System.Windows.Forms.DataGridView();
            this.btncargarlista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosCriticos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductosCriticos
            // 
            this.dataGridViewProductosCriticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductosCriticos.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewProductosCriticos.Name = "dataGridViewProductosCriticos";
            this.dataGridViewProductosCriticos.Size = new System.Drawing.Size(495, 367);
            this.dataGridViewProductosCriticos.TabIndex = 0;
            // 
            // btncargarlista
            // 
            this.btncargarlista.Location = new System.Drawing.Point(36, 29);
            this.btncargarlista.Name = "btncargarlista";
            this.btncargarlista.Size = new System.Drawing.Size(75, 23);
            this.btncargarlista.TabIndex = 1;
            this.btncargarlista.Text = "Cargar";
            this.btncargarlista.UseVisualStyleBackColor = true;
            this.btncargarlista.Click += new System.EventHandler(this.btncargarlista_Click);
            // 
            // ProductosCriticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btncargarlista);
            this.Controls.Add(this.dataGridViewProductosCriticos);
            this.Name = "ProductosCriticos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosCriticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductosCriticos;
        private System.Windows.Forms.Button btncargarlista;
    }
}