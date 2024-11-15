namespace TemplateTPIntegrador.Venta
{
    partial class DevolverVenta
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
            this.ventadevolver = new System.Windows.Forms.TextBox();
            this.btndevolver = new System.Windows.Forms.Button();
            this.lblusuarioeliminar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ventadevolver
            // 
            this.ventadevolver.Location = new System.Drawing.Point(142, 168);
            this.ventadevolver.Name = "ventadevolver";
            this.ventadevolver.Size = new System.Drawing.Size(100, 20);
            this.ventadevolver.TabIndex = 5;
            // 
            // btndevolver
            // 
            this.btndevolver.Location = new System.Drawing.Point(142, 242);
            this.btndevolver.Name = "btndevolver";
            this.btndevolver.Size = new System.Drawing.Size(100, 23);
            this.btndevolver.TabIndex = 4;
            this.btndevolver.Text = "Devolucion";
            this.btndevolver.UseVisualStyleBackColor = true;
            this.btndevolver.Click += new System.EventHandler(this.btnusuarioeliminar_Click);
            // 
            // lblusuarioeliminar
            // 
            this.lblusuarioeliminar.AutoSize = true;
            this.lblusuarioeliminar.Location = new System.Drawing.Point(162, 128);
            this.lblusuarioeliminar.Name = "lblusuarioeliminar";
            this.lblusuarioeliminar.Size = new System.Drawing.Size(49, 13);
            this.lblusuarioeliminar.TabIndex = 3;
            this.lblusuarioeliminar.Text = "ID Venta";
            // 
            // DevolverVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.ventadevolver);
            this.Controls.Add(this.btndevolver);
            this.Controls.Add(this.lblusuarioeliminar);
            this.Name = "DevolverVenta";
            this.Text = "DevolverVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ventadevolver;
        private System.Windows.Forms.Button btndevolver;
        private System.Windows.Forms.Label lblusuarioeliminar;
    }
}