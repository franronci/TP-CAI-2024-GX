namespace TemplateTPIntegrador.Proveedor
{
    partial class BajaProveedorf
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
            this.btnproveedorBaja = new System.Windows.Forms.Button();
            this.txtproveedorBaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baja proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuit";
            // 
            // btnproveedorBaja
            // 
            this.btnproveedorBaja.Location = new System.Drawing.Point(129, 262);
            this.btnproveedorBaja.Name = "btnproveedorBaja";
            this.btnproveedorBaja.Size = new System.Drawing.Size(100, 23);
            this.btnproveedorBaja.TabIndex = 2;
            this.btnproveedorBaja.Text = "Aceptar";
            this.btnproveedorBaja.UseVisualStyleBackColor = true;
            // 
            // txtproveedorBaja
            // 
            this.txtproveedorBaja.Location = new System.Drawing.Point(129, 177);
            this.txtproveedorBaja.Name = "txtproveedorBaja";
            this.txtproveedorBaja.Size = new System.Drawing.Size(100, 20);
            this.txtproveedorBaja.TabIndex = 3;
            // 
            // BajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.txtproveedorBaja);
            this.Controls.Add(this.btnproveedorBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BajaProveedor";
            this.Text = "Baja Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnproveedorBaja;
        private System.Windows.Forms.TextBox txtproveedorBaja;
    }
}