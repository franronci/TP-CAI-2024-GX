namespace TemplateTPIntegrador
{
    partial class CreacionCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LbNombreUsuario;
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.ApellidoUsuario = new System.Windows.Forms.TextBox();
            this.UsernameUsuario = new System.Windows.Forms.TextBox();
            this.DocumentoUsuario = new System.Windows.Forms.TextBox();
            this.Errores = new System.Windows.Forms.Label();
            this.LbApellidoUsuario = new System.Windows.Forms.Label();
            this.LbMailUsuario = new System.Windows.Forms.Label();
            this.LbDocUsuario = new System.Windows.Forms.Label();
            this.TelefonoUsuario = new System.Windows.Forms.TextBox();
            this.FechaNacimientoUsuario = new System.Windows.Forms.DateTimePicker();
            this.MailUsuario = new System.Windows.Forms.TextBox();
            this.RolUsuario = new System.Windows.Forms.ComboBox();
            this.LbTelUsuario = new System.Windows.Forms.Label();
            this.LbFechaNacimiento = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbRolUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DireccionUsuario = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            LbNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.Location = new System.Drawing.Point(21, 13);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Size = new System.Drawing.Size(44, 13);
            LbNombreUsuario.TabIndex = 6;
            LbNombreUsuario.Text = "Nombre";
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Location = new System.Drawing.Point(24, 345);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.BtnCrearUsuario.TabIndex = 0;
            this.BtnCrearUsuario.Text = "Crear Usuario";
            this.BtnCrearUsuario.UseVisualStyleBackColor = true;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Location = new System.Drawing.Point(24, 35);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.NombreUsuario.TabIndex = 1;
            this.NombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.Location = new System.Drawing.Point(21, 95);
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.Size = new System.Drawing.Size(100, 20);
            this.ApellidoUsuario.TabIndex = 2;
            this.ApellidoUsuario.TextChanged += new System.EventHandler(this.ApellidoUsuario_TextChanged);
            // 
            // UsernameUsuario
            // 
            this.UsernameUsuario.Location = new System.Drawing.Point(240, 151);
            this.UsernameUsuario.Name = "UsernameUsuario";
            this.UsernameUsuario.Size = new System.Drawing.Size(100, 20);
            this.UsernameUsuario.TabIndex = 3;
            this.UsernameUsuario.TextChanged += new System.EventHandler(this.UsernameUsuario_TextChanged);
            // 
            // DocumentoUsuario
            // 
            this.DocumentoUsuario.Location = new System.Drawing.Point(21, 212);
            this.DocumentoUsuario.Name = "DocumentoUsuario";
            this.DocumentoUsuario.Size = new System.Drawing.Size(100, 20);
            this.DocumentoUsuario.TabIndex = 4;
            // 
            // Errores
            // 
            this.Errores.ForeColor = System.Drawing.Color.Red;
            this.Errores.Location = new System.Drawing.Point(21, 268);
            this.Errores.Name = "Errores";
            this.Errores.Size = new System.Drawing.Size(100, 23);
            this.Errores.TabIndex = 5;
            this.Errores.Text = "errores";
            this.Errores.Visible = false;
            // 
            // LbApellidoUsuario
            // 
            this.LbApellidoUsuario.AutoSize = true;
            this.LbApellidoUsuario.Location = new System.Drawing.Point(21, 79);
            this.LbApellidoUsuario.Name = "LbApellidoUsuario";
            this.LbApellidoUsuario.Size = new System.Drawing.Size(44, 13);
            this.LbApellidoUsuario.TabIndex = 7;
            this.LbApellidoUsuario.Text = "Apellido";
            // 
            // LbMailUsuario
            // 
            this.LbMailUsuario.AutoSize = true;
            this.LbMailUsuario.Location = new System.Drawing.Point(21, 128);
            this.LbMailUsuario.Name = "LbMailUsuario";
            this.LbMailUsuario.Size = new System.Drawing.Size(26, 13);
            this.LbMailUsuario.TabIndex = 8;
            this.LbMailUsuario.Text = "Mail";
            // 
            // LbDocUsuario
            // 
            this.LbDocUsuario.AutoSize = true;
            this.LbDocUsuario.Location = new System.Drawing.Point(21, 189);
            this.LbDocUsuario.Name = "LbDocUsuario";
            this.LbDocUsuario.Size = new System.Drawing.Size(62, 13);
            this.LbDocUsuario.TabIndex = 9;
            this.LbDocUsuario.Text = "Documento";
            // 
            // TelefonoUsuario
            // 
            this.TelefonoUsuario.Location = new System.Drawing.Point(240, 35);
            this.TelefonoUsuario.Name = "TelefonoUsuario";
            this.TelefonoUsuario.Size = new System.Drawing.Size(100, 20);
            this.TelefonoUsuario.TabIndex = 10;
            // 
            // FechaNacimientoUsuario
            // 
            this.FechaNacimientoUsuario.Location = new System.Drawing.Point(240, 92);
            this.FechaNacimientoUsuario.MaxDate = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            this.FechaNacimientoUsuario.MinDate = new System.DateTime(1949, 1, 1, 0, 0, 0, 0);
            this.FechaNacimientoUsuario.Name = "FechaNacimientoUsuario";
            this.FechaNacimientoUsuario.Size = new System.Drawing.Size(200, 20);
            this.FechaNacimientoUsuario.TabIndex = 11;
            this.FechaNacimientoUsuario.Value = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            this.FechaNacimientoUsuario.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MailUsuario
            // 
            this.MailUsuario.Location = new System.Drawing.Point(21, 151);
            this.MailUsuario.Name = "MailUsuario";
            this.MailUsuario.Size = new System.Drawing.Size(100, 20);
            this.MailUsuario.TabIndex = 12;
            this.MailUsuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RolUsuario
            // 
            this.RolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolUsuario.FormattingEnabled = true;
            this.RolUsuario.Items.AddRange(new object[] {
            "Supervisor",
            "Vendedor"});
            this.RolUsuario.Location = new System.Drawing.Point(240, 211);
            this.RolUsuario.Name = "RolUsuario";
            this.RolUsuario.Size = new System.Drawing.Size(121, 21);
            this.RolUsuario.TabIndex = 13;
            this.RolUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LbTelUsuario
            // 
            this.LbTelUsuario.AutoSize = true;
            this.LbTelUsuario.Location = new System.Drawing.Point(240, 12);
            this.LbTelUsuario.Name = "LbTelUsuario";
            this.LbTelUsuario.Size = new System.Drawing.Size(49, 13);
            this.LbTelUsuario.TabIndex = 14;
            this.LbTelUsuario.Text = "Telefono";
            // 
            // LbFechaNacimiento
            // 
            this.LbFechaNacimiento.AutoSize = true;
            this.LbFechaNacimiento.Location = new System.Drawing.Point(240, 76);
            this.LbFechaNacimiento.Name = "LbFechaNacimiento";
            this.LbFechaNacimiento.Size = new System.Drawing.Size(110, 13);
            this.LbFechaNacimiento.TabIndex = 15;
            this.LbFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(240, 128);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(98, 13);
            this.LbUsername.TabIndex = 16;
            this.LbUsername.Text = "Nombre de Usuario";
            // 
            // LbRolUsuario
            // 
            this.LbRolUsuario.AutoSize = true;
            this.LbRolUsuario.Location = new System.Drawing.Point(240, 189);
            this.LbRolUsuario.Name = "LbRolUsuario";
            this.LbRolUsuario.Size = new System.Drawing.Size(23, 13);
            this.LbRolUsuario.TabIndex = 17;
            this.LbRolUsuario.Text = "Rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DireccionUsuario
            // 
            this.DireccionUsuario.Location = new System.Drawing.Point(420, 212);
            this.DireccionUsuario.Name = "DireccionUsuario";
            this.DireccionUsuario.Size = new System.Drawing.Size(100, 20);
            this.DireccionUsuario.TabIndex = 20;
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Location = new System.Drawing.Point(417, 189);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionUsuario.TabIndex = 21;
            this.lblDireccionUsuario.Text = "Direccion";
            // 
            // CreacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.lblDireccionUsuario);
            this.Controls.Add(this.DireccionUsuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbRolUsuario);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.LbFechaNacimiento);
            this.Controls.Add(this.LbTelUsuario);
            this.Controls.Add(this.RolUsuario);
            this.Controls.Add(this.MailUsuario);
            this.Controls.Add(this.FechaNacimientoUsuario);
            this.Controls.Add(this.TelefonoUsuario);
            this.Controls.Add(this.LbDocUsuario);
            this.Controls.Add(this.LbMailUsuario);
            this.Controls.Add(this.LbApellidoUsuario);
            this.Controls.Add(LbNombreUsuario);
            this.Controls.Add(this.Errores);
            this.Controls.Add(this.DocumentoUsuario);
            this.Controls.Add(this.UsernameUsuario);
            this.Controls.Add(this.ApellidoUsuario);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.BtnCrearUsuario);
            this.Name = "CreacionUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.CreacionUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.TextBox ApellidoUsuario;
        private System.Windows.Forms.TextBox UsernameUsuario;
        private System.Windows.Forms.TextBox DocumentoUsuario;
        private System.Windows.Forms.Label Errores;
        private System.Windows.Forms.Label LbApellidoUsuario;
        private System.Windows.Forms.Label LbMailUsuario;
        private System.Windows.Forms.Label LbDocUsuario;
        private System.Windows.Forms.TextBox TelefonoUsuario;
        private System.Windows.Forms.DateTimePicker FechaNacimientoUsuario;
        private System.Windows.Forms.TextBox MailUsuario;
        private System.Windows.Forms.ComboBox RolUsuario;
        private System.Windows.Forms.Label LbTelUsuario;
        private System.Windows.Forms.Label LbFechaNacimiento;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbRolUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DireccionUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
    }
}

   


