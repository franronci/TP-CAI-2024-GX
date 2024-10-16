namespace TemplateTPIntegrador
{
    partial class frmCambiarContraseña
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
            this.btnConfirmarContraseña = new System.Windows.Forms.Button();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtRepetirContraseñaNueva = new System.Windows.Forms.TextBox();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.lblRepetirContraseñaNueva = new System.Windows.Forms.Label();
            this.btnCancelarContraseña = new System.Windows.Forms.Button();
            this.lblCambiodeContraseña = new System.Windows.Forms.Label();
            this.lblErroresContraseña = new System.Windows.Forms.Label();
            this.lblInformacionContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmarContraseña
            // 
            this.btnConfirmarContraseña.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirmarContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmarContraseña.Location = new System.Drawing.Point(215, 367);
            this.btnConfirmarContraseña.Name = "btnConfirmarContraseña";
            this.btnConfirmarContraseña.Size = new System.Drawing.Size(162, 47);
            this.btnConfirmarContraseña.TabIndex = 0;
            this.btnConfirmarContraseña.Text = "CONFIRMAR";
            this.btnConfirmarContraseña.UseVisualStyleBackColor = false;
            this.btnConfirmarContraseña.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.CausesValidation = false;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtContraseñaActual.Location = new System.Drawing.Point(318, 106);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(201, 24);
            this.txtContraseñaActual.TabIndex = 1;
            this.txtContraseñaActual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.CausesValidation = false;
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtContraseñaNueva.Location = new System.Drawing.Point(318, 165);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(201, 24);
            this.txtContraseñaNueva.TabIndex = 2;
            this.txtContraseñaNueva.TextChanged += new System.EventHandler(this.txtContraseñaNueva_TextChanged);
            // 
            // txtRepetirContraseñaNueva
            // 
            this.txtRepetirContraseñaNueva.CausesValidation = false;
            this.txtRepetirContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRepetirContraseñaNueva.Location = new System.Drawing.Point(318, 240);
            this.txtRepetirContraseñaNueva.Name = "txtRepetirContraseñaNueva";
            this.txtRepetirContraseñaNueva.Size = new System.Drawing.Size(201, 24);
            this.txtRepetirContraseñaNueva.TabIndex = 3;
            this.txtRepetirContraseñaNueva.TextChanged += new System.EventHandler(this.txtRepetirContraseñaNueva_TextChanged);
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContraseñaActual.Location = new System.Drawing.Point(87, 109);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(198, 18);
            this.lblContraseñaActual.TabIndex = 4;
            this.lblContraseñaActual.Text = "Contraseña actual / temporal";
            this.lblContraseñaActual.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContraseñaNueva.Location = new System.Drawing.Point(87, 171);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(134, 18);
            this.lblContraseñaNueva.TabIndex = 5;
            this.lblContraseñaNueva.Text = "Nueva contraseña*";
            this.lblContraseñaNueva.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRepetirContraseñaNueva
            // 
            this.lblRepetirContraseñaNueva.AutoSize = true;
            this.lblRepetirContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRepetirContraseñaNueva.Location = new System.Drawing.Point(87, 246);
            this.lblRepetirContraseñaNueva.Name = "lblRepetirContraseñaNueva";
            this.lblRepetirContraseñaNueva.Size = new System.Drawing.Size(171, 18);
            this.lblRepetirContraseñaNueva.TabIndex = 6;
            this.lblRepetirContraseñaNueva.Text = "Repita nueva contraseña";
            this.lblRepetirContraseñaNueva.Click += new System.EventHandler(this.lblRepetirContraseñaNueva_Click);
            // 
            // btnCancelarContraseña
            // 
            this.btnCancelarContraseña.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarContraseña.Location = new System.Drawing.Point(499, 367);
            this.btnCancelarContraseña.Name = "btnCancelarContraseña";
            this.btnCancelarContraseña.Size = new System.Drawing.Size(163, 47);
            this.btnCancelarContraseña.TabIndex = 7;
            this.btnCancelarContraseña.Text = "CANCELAR";
            this.btnCancelarContraseña.UseVisualStyleBackColor = false;
            this.btnCancelarContraseña.Click += new System.EventHandler(this.btnCancelarContraseña_Click);
            // 
            // lblCambiodeContraseña
            // 
            this.lblCambiodeContraseña.AutoSize = true;
            this.lblCambiodeContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCambiodeContraseña.Location = new System.Drawing.Point(85, 38);
            this.lblCambiodeContraseña.Name = "lblCambiodeContraseña";
            this.lblCambiodeContraseña.Size = new System.Drawing.Size(390, 29);
            this.lblCambiodeContraseña.TabIndex = 8;
            this.lblCambiodeContraseña.Text = "Establecer una nueva contraseña";
            this.lblCambiodeContraseña.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblErroresContraseña
            // 
            this.lblErroresContraseña.AutoSize = true;
            this.lblErroresContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblErroresContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErroresContraseña.Location = new System.Drawing.Point(591, 240);
            this.lblErroresContraseña.Name = "lblErroresContraseña";
            this.lblErroresContraseña.Size = new System.Drawing.Size(58, 18);
            this.lblErroresContraseña.TabIndex = 9;
            this.lblErroresContraseña.Text = "Errores";
            this.lblErroresContraseña.Click += new System.EventHandler(this.Label5_Click_1);
            // 
            // lblInformacionContraseña
            // 
            this.lblInformacionContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInformacionContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblInformacionContraseña.Location = new System.Drawing.Point(591, 106);
            this.lblInformacionContraseña.Name = "lblInformacionContraseña";
            this.lblInformacionContraseña.Size = new System.Drawing.Size(219, 72);
            this.lblInformacionContraseña.TabIndex = 10;
            this.lblInformacionContraseña.Text = "* Debe tener entre 8 y 15 caracteres, al menos un número y una letra mayúscula";
            this.lblInformacionContraseña.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.lblInformacionContraseña);
            this.Controls.Add(this.lblErroresContraseña);
            this.Controls.Add(this.lblCambiodeContraseña);
            this.Controls.Add(this.btnCancelarContraseña);
            this.Controls.Add(this.lblRepetirContraseñaNueva);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.lblContraseñaActual);
            this.Controls.Add(this.txtRepetirContraseñaNueva);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.btnConfirmarContraseña);
            this.Name = "frmCambiarContraseña";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarContraseña;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtRepetirContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.Label lblRepetirContraseñaNueva;
        private System.Windows.Forms.Button btnCancelarContraseña;
        private System.Windows.Forms.Label lblCambiodeContraseña;
        private System.Windows.Forms.Label lblErroresContraseña;
        private System.Windows.Forms.Label lblInformacionContraseña;
    }
}