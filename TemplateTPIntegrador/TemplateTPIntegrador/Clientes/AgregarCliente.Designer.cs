namespace TemplateTPIntegrador.Clientes
{
    partial class AgregarCliente
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
            System.Windows.Forms.Label LbNombreUsuario;
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbRolUsuario = new System.Windows.Forms.Label();
            this.LbFechaNacimiento = new System.Windows.Forms.Label();
            this.LbTelUsuario = new System.Windows.Forms.Label();
            this.MailCliente = new System.Windows.Forms.TextBox();
            this.FechaNacimientoCliente = new System.Windows.Forms.DateTimePicker();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.LbDocUsuario = new System.Windows.Forms.Label();
            this.LbMailUsuario = new System.Windows.Forms.Label();
            this.LbApellidoUsuario = new System.Windows.Forms.Label();
            this.Errores1 = new System.Windows.Forms.Label();
            this.DocumentoCliente = new System.Windows.Forms.TextBox();
            this.HostCliente = new System.Windows.Forms.TextBox();
            this.ApellidoCliente = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.BtnCrearCliente = new System.Windows.Forms.Button();
            LbNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Location = new System.Drawing.Point(261, 170);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionUsuario.TabIndex = 42;
            this.lblDireccionUsuario.Text = "Direccion";
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Location = new System.Drawing.Point(261, 186);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(100, 20);
            this.DireccionCliente.TabIndex = 41;
            this.DireccionCliente.TextChanged += new System.EventHandler(this.DireccionUsuario_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LbRolUsuario
            // 
            this.LbRolUsuario.AutoSize = true;
            this.LbRolUsuario.Location = new System.Drawing.Point(261, 224);
            this.LbRolUsuario.Name = "LbRolUsuario";
            this.LbRolUsuario.Size = new System.Drawing.Size(29, 13);
            this.LbRolUsuario.TabIndex = 39;
            this.LbRolUsuario.Text = "Host";
            // 
            // LbFechaNacimiento
            // 
            this.LbFechaNacimiento.AutoSize = true;
            this.LbFechaNacimiento.Location = new System.Drawing.Point(261, 111);
            this.LbFechaNacimiento.Name = "LbFechaNacimiento";
            this.LbFechaNacimiento.Size = new System.Drawing.Size(110, 13);
            this.LbFechaNacimiento.TabIndex = 37;
            this.LbFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // LbTelUsuario
            // 
            this.LbTelUsuario.AutoSize = true;
            this.LbTelUsuario.Location = new System.Drawing.Point(261, 47);
            this.LbTelUsuario.Name = "LbTelUsuario";
            this.LbTelUsuario.Size = new System.Drawing.Size(49, 13);
            this.LbTelUsuario.TabIndex = 36;
            this.LbTelUsuario.Text = "Telefono";
            // 
            // MailCliente
            // 
            this.MailCliente.Location = new System.Drawing.Point(42, 186);
            this.MailCliente.Name = "MailCliente";
            this.MailCliente.Size = new System.Drawing.Size(100, 20);
            this.MailCliente.TabIndex = 34;
            // 
            // FechaNacimientoCliente
            // 
            this.FechaNacimientoCliente.Location = new System.Drawing.Point(261, 127);
            this.FechaNacimientoCliente.MaxDate = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            this.FechaNacimientoCliente.MinDate = new System.DateTime(1949, 1, 1, 0, 0, 0, 0);
            this.FechaNacimientoCliente.Name = "FechaNacimientoCliente";
            this.FechaNacimientoCliente.Size = new System.Drawing.Size(200, 20);
            this.FechaNacimientoCliente.TabIndex = 33;
            this.FechaNacimientoCliente.Value = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(261, 70);
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.TelefonoCliente.TabIndex = 32;
            // 
            // LbDocUsuario
            // 
            this.LbDocUsuario.AutoSize = true;
            this.LbDocUsuario.Location = new System.Drawing.Point(42, 224);
            this.LbDocUsuario.Name = "LbDocUsuario";
            this.LbDocUsuario.Size = new System.Drawing.Size(62, 13);
            this.LbDocUsuario.TabIndex = 31;
            this.LbDocUsuario.Text = "Documento";
            // 
            // LbMailUsuario
            // 
            this.LbMailUsuario.AutoSize = true;
            this.LbMailUsuario.Location = new System.Drawing.Point(42, 163);
            this.LbMailUsuario.Name = "LbMailUsuario";
            this.LbMailUsuario.Size = new System.Drawing.Size(26, 13);
            this.LbMailUsuario.TabIndex = 30;
            this.LbMailUsuario.Text = "Mail";
            // 
            // LbApellidoUsuario
            // 
            this.LbApellidoUsuario.AutoSize = true;
            this.LbApellidoUsuario.Location = new System.Drawing.Point(42, 114);
            this.LbApellidoUsuario.Name = "LbApellidoUsuario";
            this.LbApellidoUsuario.Size = new System.Drawing.Size(44, 13);
            this.LbApellidoUsuario.TabIndex = 29;
            this.LbApellidoUsuario.Text = "Apellido";
            // 
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.Location = new System.Drawing.Point(42, 48);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Size = new System.Drawing.Size(44, 13);
            LbNombreUsuario.TabIndex = 28;
            LbNombreUsuario.Text = "Nombre";
            // 
            // Errores1
            // 
            this.Errores1.ForeColor = System.Drawing.Color.Red;
            this.Errores1.Location = new System.Drawing.Point(42, 303);
            this.Errores1.Name = "Errores1";
            this.Errores1.Size = new System.Drawing.Size(100, 23);
            this.Errores1.TabIndex = 27;
            this.Errores1.Text = "errorescliente";
            this.Errores1.Visible = false;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.Location = new System.Drawing.Point(42, 247);
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.Size = new System.Drawing.Size(100, 20);
            this.DocumentoCliente.TabIndex = 26;
            // 
            // HostCliente
            // 
            this.HostCliente.Location = new System.Drawing.Point(261, 247);
            this.HostCliente.Name = "HostCliente";
            this.HostCliente.Size = new System.Drawing.Size(100, 20);
            this.HostCliente.TabIndex = 25;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Location = new System.Drawing.Point(42, 130);
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.ApellidoCliente.TabIndex = 24;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(45, 70);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(100, 20);
            this.NombreCliente.TabIndex = 23;
            this.NombreCliente.TextChanged += new System.EventHandler(this.NombreCliente_TextChanged);
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Location = new System.Drawing.Point(45, 380);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(100, 23);
            this.BtnCrearCliente.TabIndex = 22;
            this.BtnCrearCliente.Text = "Alta cliente";
            this.BtnCrearCliente.UseVisualStyleBackColor = true;
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearCliente_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.lblDireccionUsuario);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbRolUsuario);
            this.Controls.Add(this.LbFechaNacimiento);
            this.Controls.Add(this.LbTelUsuario);
            this.Controls.Add(this.MailCliente);
            this.Controls.Add(this.FechaNacimientoCliente);
            this.Controls.Add(this.TelefonoCliente);
            this.Controls.Add(this.LbDocUsuario);
            this.Controls.Add(this.LbMailUsuario);
            this.Controls.Add(this.LbApellidoUsuario);
            this.Controls.Add(LbNombreUsuario);
            this.Controls.Add(this.Errores1);
            this.Controls.Add(this.DocumentoCliente);
            this.Controls.Add(this.HostCliente);
            this.Controls.Add(this.ApellidoCliente);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.BtnCrearCliente);
            this.Name = "AgregarCliente";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbRolUsuario;
        private System.Windows.Forms.Label LbFechaNacimiento;
        private System.Windows.Forms.Label LbTelUsuario;
        private System.Windows.Forms.TextBox MailCliente;
        private System.Windows.Forms.DateTimePicker FechaNacimientoCliente;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.Label LbDocUsuario;
        private System.Windows.Forms.Label LbMailUsuario;
        private System.Windows.Forms.Label LbApellidoUsuario;
        private System.Windows.Forms.Label Errores1;
        private System.Windows.Forms.TextBox DocumentoCliente;
        private System.Windows.Forms.TextBox HostCliente;
        private System.Windows.Forms.TextBox ApellidoCliente;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.Button BtnCrearCliente;
    }
}