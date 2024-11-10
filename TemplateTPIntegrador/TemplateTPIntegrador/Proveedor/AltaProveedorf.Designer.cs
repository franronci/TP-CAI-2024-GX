namespace TemplateTPIntegrador.Proveedor
{
    partial class AltaProveedorf
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreProveedor = new System.Windows.Forms.TextBox();
            this.txtapellidoProveedor = new System.Windows.Forms.TextBox();
            this.txtmailProveedor = new System.Windows.Forms.TextBox();
            this.txtcuitproveedor = new System.Windows.Forms.TextBox();
            this.btnaltaProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuit";
            // 
            // txtnombreProveedor
            // 
            this.txtnombreProveedor.Location = new System.Drawing.Point(51, 148);
            this.txtnombreProveedor.Name = "txtnombreProveedor";
            this.txtnombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtnombreProveedor.TabIndex = 5;
            // 
            // txtapellidoProveedor
            // 
            this.txtapellidoProveedor.Location = new System.Drawing.Point(292, 148);
            this.txtapellidoProveedor.Name = "txtapellidoProveedor";
            this.txtapellidoProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtapellidoProveedor.TabIndex = 6;
            // 
            // txtmailProveedor
            // 
            this.txtmailProveedor.Location = new System.Drawing.Point(51, 280);
            this.txtmailProveedor.Name = "txtmailProveedor";
            this.txtmailProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtmailProveedor.TabIndex = 7;
            // 
            // txtcuitproveedor
            // 
            this.txtcuitproveedor.Location = new System.Drawing.Point(292, 280);
            this.txtcuitproveedor.Name = "txtcuitproveedor";
            this.txtcuitproveedor.Size = new System.Drawing.Size(100, 20);
            this.txtcuitproveedor.TabIndex = 8;
            // 
            // btnaltaProveedor
            // 
            this.btnaltaProveedor.Location = new System.Drawing.Point(54, 365);
            this.btnaltaProveedor.Name = "btnaltaProveedor";
            this.btnaltaProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnaltaProveedor.TabIndex = 9;
            this.btnaltaProveedor.Text = "Aceptar";
            this.btnaltaProveedor.UseVisualStyleBackColor = true;
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.btnaltaProveedor);
            this.Controls.Add(this.txtcuitproveedor);
            this.Controls.Add(this.txtmailProveedor);
            this.Controls.Add(this.txtapellidoProveedor);
            this.Controls.Add(this.txtnombreProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProveedor";
            this.Text = "Alta Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombreProveedor;
        private System.Windows.Forms.TextBox txtapellidoProveedor;
        private System.Windows.Forms.TextBox txtmailProveedor;
        private System.Windows.Forms.TextBox txtcuitproveedor;
        private System.Windows.Forms.Button btnaltaProveedor;
    }
}