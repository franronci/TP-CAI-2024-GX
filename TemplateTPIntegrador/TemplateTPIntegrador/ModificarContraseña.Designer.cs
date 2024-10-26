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
            this.lbObtenerNuevaContraseña = new System.Windows.Forms.Label();
            this.lbContraseñaActual = new System.Windows.Forms.Label();
            this.lbNuevaContraseña = new System.Windows.Forms.Label();
            this.lbRepetirNuevaContraseña = new System.Windows.Forms.Label();
            this.lbInformaciónContraseña = new System.Windows.Forms.Label();
            this.lbErrores = new System.Windows.Forms.Label();
            this.btnConfirmarContraseña = new System.Windows.Forms.Button();
            this.btnCancelarContraseña = new System.Windows.Forms.Button();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtRepetirContraseñaNueva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbObtenerNuevaContraseña
            // 
            this.lbObtenerNuevaContraseña.AutoSize = true;
            this.lbObtenerNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.15F);
            this.lbObtenerNuevaContraseña.Location = new System.Drawing.Point(28, 32);
            this.lbObtenerNuevaContraseña.Name = "lbObtenerNuevaContraseña";
            this.lbObtenerNuevaContraseña.Size = new System.Drawing.Size(151, 15);
            this.lbObtenerNuevaContraseña.TabIndex = 0;
            this.lbObtenerNuevaContraseña.Text = "Obtener nueva contraseña";
            this.lbObtenerNuevaContraseña.Click += new System.EventHandler(this.lbModificarContraseña_Click);
            // 
            // lbContraseñaActual
            // 
            this.lbContraseñaActual.AutoSize = true;
            this.lbContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbContraseñaActual.Location = new System.Drawing.Point(28, 123);
            this.lbContraseñaActual.Name = "lbContraseñaActual";
            this.lbContraseñaActual.Size = new System.Drawing.Size(123, 17);
            this.lbContraseñaActual.TabIndex = 1;
            this.lbContraseñaActual.Text = "Contraseña actual";
            this.lbContraseñaActual.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNuevaContraseña
            // 
            this.lbNuevaContraseña.AutoSize = true;
            this.lbNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbNuevaContraseña.Location = new System.Drawing.Point(28, 183);
            this.lbNuevaContraseña.Name = "lbNuevaContraseña";
            this.lbNuevaContraseña.Size = new System.Drawing.Size(129, 17);
            this.lbNuevaContraseña.TabIndex = 2;
            this.lbNuevaContraseña.Text = "Nueva contraseña*";
            // 
            // lbRepetirNuevaContraseña
            // 
            this.lbRepetirNuevaContraseña.AutoSize = true;
            this.lbRepetirNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbRepetirNuevaContraseña.Location = new System.Drawing.Point(28, 247);
            this.lbRepetirNuevaContraseña.Name = "lbRepetirNuevaContraseña";
            this.lbRepetirNuevaContraseña.Size = new System.Drawing.Size(177, 17);
            this.lbRepetirNuevaContraseña.TabIndex = 3;
            this.lbRepetirNuevaContraseña.Text = "Repetir nueva contraseña*";
            // 
            // lbInformaciónContraseña
            // 
            this.lbInformaciónContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.lbInformaciónContraseña.Location = new System.Drawing.Point(595, 123);
            this.lbInformaciónContraseña.Name = "lbInformaciónContraseña";
            this.lbInformaciónContraseña.Size = new System.Drawing.Size(122, 122);
            this.lbInformaciónContraseña.TabIndex = 4;
            this.lbInformaciónContraseña.Text = "*  Debe tener entre 8 y 15 caracteres, al menos un número y una letra mayúscula";
            this.lbInformaciónContraseña.Click += new System.EventHandler(this.lbInformaciónContraseña_Click);
            // 
            // lbErrores
            // 
            this.lbErrores.AutoSize = true;
            this.lbErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbErrores.Location = new System.Drawing.Point(28, 327);
            this.lbErrores.Name = "lbErrores";
            this.lbErrores.Size = new System.Drawing.Size(51, 16);
            this.lbErrores.TabIndex = 5;
            this.lbErrores.Text = "Errores";
            // 
            // btnConfirmarContraseña
            // 
            this.btnConfirmarContraseña.Location = new System.Drawing.Point(192, 501);
            this.btnConfirmarContraseña.Name = "btnConfirmarContraseña";
            this.btnConfirmarContraseña.Size = new System.Drawing.Size(104, 59);
            this.btnConfirmarContraseña.TabIndex = 6;
            this.btnConfirmarContraseña.Text = "CONFIRMAR";
            this.btnConfirmarContraseña.UseVisualStyleBackColor = true;
            this.btnConfirmarContraseña.Click += new System.EventHandler(this.button1_Click);
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
            this.txtContraseñaActual.Location = new System.Drawing.Point(256, 117);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(178, 22);
            this.txtContraseñaActual.TabIndex = 8;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(256, 177);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(178, 22);
            this.txtNuevaContraseña.TabIndex = 9;
            // 
            // txtRepetirContraseñaNueva
            // 
            this.txtRepetirContraseñaNueva.Location = new System.Drawing.Point(256, 241);
            this.txtRepetirContraseñaNueva.Name = "txtRepetirContraseñaNueva";
            this.txtRepetirContraseñaNueva.Size = new System.Drawing.Size(178, 22);
            this.txtRepetirContraseñaNueva.TabIndex = 10;
            // 
            // ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 631);
            this.Controls.Add(this.txtRepetirContraseñaNueva);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.btnCancelarContraseña);
            this.Controls.Add(this.btnConfirmarContraseña);
            this.Controls.Add(this.lbErrores);
            this.Controls.Add(this.lbInformaciónContraseña);
            this.Controls.Add(this.lbRepetirNuevaContraseña);
            this.Controls.Add(this.lbNuevaContraseña);
            this.Controls.Add(this.lbContraseñaActual);
            this.Controls.Add(this.lbObtenerNuevaContraseña);
            this.Name = "ModificarContraseña";
            this.Text = "Modificar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbObtenerNuevaContraseña;
        private System.Windows.Forms.Label lbContraseñaActual;
        private System.Windows.Forms.Label lbNuevaContraseña;
        private System.Windows.Forms.Label lbRepetirNuevaContraseña;
        private System.Windows.Forms.Label lbInformaciónContraseña;
        private System.Windows.Forms.Label lbErrores;
        private System.Windows.Forms.Button btnConfirmarContraseña;
        private System.Windows.Forms.Button btnCancelarContraseña;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtRepetirContraseñaNueva;
    }
}