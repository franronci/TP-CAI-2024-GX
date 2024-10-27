namespace TemplateTPIntegrador
{
    partial class ModificarContraseña
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
            this.lbContraseñaActual = new System.Windows.Forms.Label();
            this.lbNuevaContraseña = new System.Windows.Forms.Label();
            this.lbInformaciónContraseña = new System.Windows.Forms.Label();
            this.lbErroresContraseña = new System.Windows.Forms.Label();
            this.btnConfirmarContraseña = new System.Windows.Forms.Button();
            this.btnCancelarContraseña = new System.Windows.Forms.Button();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbContraseñaActual
            // 
            this.lbContraseñaActual.AutoSize = true;
            this.lbContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbContraseñaActual.Location = new System.Drawing.Point(36, 142);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(123, 17);
            this.lbContraseñaActual.TabIndex = 1;
            this.lbContraseñaActual.Text = "Contraseña actual";
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.AutoSize = true;
            this.lbNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbNuevaContraseña.Location = new System.Drawing.Point(36, 202);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(129, 17);
            this.lbNuevaContraseña.TabIndex = 2;
            this.lbNuevaContraseña.Text = "Nueva contraseña*";
            // 
            // lbInformaciónContraseña
            // 
            this.lbInformaciónContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbInformaciónContraseña.Location = new System.Drawing.Point(546, 142);
            this.lbInformaciónContraseña.Name = "lbInformaciónContraseña";
            this.lbInformaciónContraseña.Size = new System.Drawing.Size(165, 122);
            this.lbInformaciónContraseña.TabIndex = 4;
            this.lbInformaciónContraseña.Text = "*  Debe tener entre 8 y 15 caracteres, al menos un número y una letra mayúscula";
            // 
            // lbErroresContraseña
            // 
            this.lbErroresContraseña.AutoSize = true;
            this.lbErroresContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbErroresContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErroresContraseña.Location = new System.Drawing.Point(36, 281);
            this.lbErroresContraseña.Name = "lbErroresContraseña";
            this.lbErroresContraseña.Size = new System.Drawing.Size(51, 16);
            this.lbErroresContraseña.TabIndex = 5;
            this.lbErroresContraseña.Text = "Errores";
            // 
            // btnConfirmarContraseña
            // 
            this.btnConfirmarContraseña.Location = new System.Drawing.Point(192, 501);
            this.btnConfirmarContraseña.Name = "btnConfirmarContraseña";
            this.btnConfirmarContraseña.Size = new System.Drawing.Size(104, 59);
            this.btnConfirmarContraseña.TabIndex = 6;
            this.btnConfirmarContraseña.Text = "CONFIRMAR";
            this.btnConfirmarContraseña.UseVisualStyleBackColor = true;
            this.btnConfirmarContraseña.Click += new System.EventHandler(this.btnConfirmarContraseña_Click);
            // 
            // btnCancelarContraseña
            // 
            this.btnCancelarContraseña.Location = new System.Drawing.Point(416, 501);
            this.btnCancelarContraseña.Name = "btnCancelarContraseña";
            this.btnCancelarContraseña.Size = new System.Drawing.Size(104, 59);
            this.btnCancelarContraseña.TabIndex = 7;
            this.btnCancelarContraseña.Text = "CANCELAR";
            this.btnCancelarContraseña.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(264, 137);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(178, 22);
            this.txtContraseñaActual.TabIndex = 8;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(264, 197);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(178, 22);
            this.txtNuevaContraseña.TabIndex = 9;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitulo.Location = new System.Drawing.Point(34, 47);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(456, 33);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Obtener nueva contraseña";
            // 
            // ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 631);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.btnCancelarContraseña);
            this.Controls.Add(this.btnConfirmarContraseña);
            this.Controls.Add(this.lbErroresContraseña);
            this.Controls.Add(this.lbInformaciónContraseña);
            this.Controls.Add(this.lbNuevaContraseña);
            this.Controls.Add(this.lbContraseñaActual);
            this.Name = "ModificarContraseña";
            this.Text = "Modificar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbContraseñaActual;
        private System.Windows.Forms.Label lbNuevaContraseña;
        private System.Windows.Forms.Label lbInformaciónContraseña;
        private System.Windows.Forms.Label lbErroresContraseña;
        private System.Windows.Forms.Button btnConfirmarContraseña;
        private System.Windows.Forms.Button btnCancelarContraseña;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label lbTitulo;
    }
}