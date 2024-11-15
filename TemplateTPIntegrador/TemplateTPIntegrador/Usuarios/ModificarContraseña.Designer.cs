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
            this.lbContraseñaActual.Location = new System.Drawing.Point(27, 122);
            this.lbContraseñaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(93, 13);
            this.lbContraseñaActual.TabIndex = 1;
            this.lbContraseñaActual.Text = "Contraseña actual";
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.AutoSize = true;
            this.lbNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbNuevaContraseña.Location = new System.Drawing.Point(27, 171);
            this.lbNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(99, 13);
            this.lbNuevaContraseña.TabIndex = 2;
            this.lbNuevaContraseña.Text = "Nueva contraseña*";
            // 
            // lbInformaciónContraseña
            // 
            this.lbInformaciónContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbInformaciónContraseña.Location = new System.Drawing.Point(410, 115);
            this.lbInformaciónContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInformaciónContraseña.Name = "lbInformaciónContraseña";
            this.lbInformaciónContraseña.Size = new System.Drawing.Size(124, 99);
            this.lbInformaciónContraseña.TabIndex = 4;
            this.lbInformaciónContraseña.Text = "*  Debe tener entre 8 y 15 caracteres, al menos un número y una letra mayúscula";
            // 
            // lbErroresContraseña
            // 
            this.lbErroresContraseña.AutoSize = true;
            this.lbErroresContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbErroresContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErroresContraseña.Location = new System.Drawing.Point(27, 213);
            this.lbErroresContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbErroresContraseña.Name = "lbErroresContraseña";
            this.lbErroresContraseña.Size = new System.Drawing.Size(40, 13);
            this.lbErroresContraseña.TabIndex = 5;
            this.lbErroresContraseña.Text = "Errores";
            // 
            // btnConfirmarContraseña
            // 
            this.btnConfirmarContraseña.Location = new System.Drawing.Point(144, 407);
            this.btnConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarContraseña.Name = "btnConfirmarContraseña";
            this.btnConfirmarContraseña.Size = new System.Drawing.Size(101, 48);
            this.btnConfirmarContraseña.TabIndex = 6;
            this.btnConfirmarContraseña.Text = "CONFIRMAR";
            this.btnConfirmarContraseña.UseVisualStyleBackColor = true;
            this.btnConfirmarContraseña.Click += new System.EventHandler(this.btnConfirmarContraseña_Click);
            // 
            // btnCancelarContraseña
            // 
            this.btnCancelarContraseña.Location = new System.Drawing.Point(312, 407);
            this.btnCancelarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarContraseña.Name = "btnCancelarContraseña";
            this.btnCancelarContraseña.Size = new System.Drawing.Size(105, 48);
            this.btnCancelarContraseña.TabIndex = 7;
            this.btnCancelarContraseña.Text = "CANCELAR";
            this.btnCancelarContraseña.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(198, 118);
            this.txtContraseñaActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(134, 20);
            this.txtContraseñaActual.TabIndex = 8;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(198, 167);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(134, 20);
            this.txtNuevaContraseña.TabIndex = 9;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitulo.Location = new System.Drawing.Point(26, 38);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(342, 27);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Obtener nueva contraseña";
            // 
            // ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 513);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.btnCancelarContraseña);
            this.Controls.Add(this.btnConfirmarContraseña);
            this.Controls.Add(this.lbErroresContraseña);
            this.Controls.Add(this.lbInformaciónContraseña);
            this.Controls.Add(this.lbNuevaContraseña);
            this.Controls.Add(this.lbContraseñaActual);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarContraseña";
            this.Text = "Modificar contraseña";
            this.Load += new System.EventHandler(this.ModificarContraseña_Load);
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