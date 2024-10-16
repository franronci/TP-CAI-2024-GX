namespace TemplateTPIntegrador
{
    partial class frmCreacionUsuario
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtUsernameUsuario = new System.Windows.Forms.TextBox();
            this.txtDocumentoUsuario = new System.Windows.Forms.TextBox();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblMailUsuario = new System.Windows.Forms.Label();
            this.lblDocUsuario = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoUsuario = new System.Windows.Forms.DateTimePicker();
            this.txtMailUsuario = new System.Windows.Forms.TextBox();
            this.cmbRolUsuario = new System.Windows.Forms.ComboBox();
            this.LblTelUsuario = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.btnVolverCrearUsuario = new System.Windows.Forms.Button();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(33, 100);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(56, 16);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(27, 486);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(133, 28);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(37, 127);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(33, 201);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtApellidoUsuario.TabIndex = 2;
            this.txtApellidoUsuario.TextChanged += new System.EventHandler(this.ApellidoUsuario_TextChanged);
            // 
            // txtUsernameUsuario
            // 
            this.txtUsernameUsuario.Location = new System.Drawing.Point(325, 270);
            this.txtUsernameUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameUsuario.Name = "txtUsernameUsuario";
            this.txtUsernameUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsernameUsuario.TabIndex = 3;
            this.txtUsernameUsuario.TextChanged += new System.EventHandler(this.UsernameUsuario_TextChanged);
            // 
            // txtDocumentoUsuario
            // 
            this.txtDocumentoUsuario.Location = new System.Drawing.Point(33, 345);
            this.txtDocumentoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentoUsuario.Name = "txtDocumentoUsuario";
            this.txtDocumentoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtDocumentoUsuario.TabIndex = 4;
            this.txtDocumentoUsuario.TextChanged += new System.EventHandler(this.ContraseñaUsuario_TextChanged);
            // 
            // lblErrores
            // 
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(33, 414);
            this.lblErrores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(133, 28);
            this.lblErrores.TabIndex = 5;
            this.lblErrores.Text = "Errores";
            this.lblErrores.Visible = false;
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Location = new System.Drawing.Point(33, 181);
            this.lblApellidoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblApellidoUsuario.TabIndex = 7;
            this.lblApellidoUsuario.Text = "Apellido";
            // 
            // lblMailUsuario
            // 
            this.lblMailUsuario.AutoSize = true;
            this.lblMailUsuario.Location = new System.Drawing.Point(33, 242);
            this.lblMailUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailUsuario.Name = "lblMailUsuario";
            this.lblMailUsuario.Size = new System.Drawing.Size(32, 16);
            this.lblMailUsuario.TabIndex = 8;
            this.lblMailUsuario.Text = "Mail";
            // 
            // lblDocUsuario
            // 
            this.lblDocUsuario.AutoSize = true;
            this.lblDocUsuario.Location = new System.Drawing.Point(33, 317);
            this.lblDocUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocUsuario.Name = "lblDocUsuario";
            this.lblDocUsuario.Size = new System.Drawing.Size(76, 16);
            this.lblDocUsuario.TabIndex = 9;
            this.lblDocUsuario.Text = "Documento";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(325, 127);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoUsuario.TabIndex = 10;
            // 
            // dtpFechaNacimientoUsuario
            // 
            this.dtpFechaNacimientoUsuario.Location = new System.Drawing.Point(325, 197);
            this.dtpFechaNacimientoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimientoUsuario.MaxDate = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            this.dtpFechaNacimientoUsuario.MinDate = new System.DateTime(1949, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimientoUsuario.Name = "dtpFechaNacimientoUsuario";
            this.dtpFechaNacimientoUsuario.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimientoUsuario.TabIndex = 11;
            this.dtpFechaNacimientoUsuario.Value = new System.DateTime(2024, 9, 15, 0, 0, 0, 0);
            this.dtpFechaNacimientoUsuario.ValueChanged += new System.EventHandler(this.FechaNacimientoUsuario_ValueChanged);
            // 
            // txtMailUsuario
            // 
            this.txtMailUsuario.Location = new System.Drawing.Point(33, 270);
            this.txtMailUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMailUsuario.Name = "txtMailUsuario";
            this.txtMailUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtMailUsuario.TabIndex = 12;
            // 
            // cmbRolUsuario
            // 
            this.cmbRolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolUsuario.FormattingEnabled = true;
            this.cmbRolUsuario.Items.AddRange(new object[] {
            "Supervisor",
            "Vendedor"});
            this.cmbRolUsuario.Location = new System.Drawing.Point(325, 344);
            this.cmbRolUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRolUsuario.Name = "cmbRolUsuario";
            this.cmbRolUsuario.Size = new System.Drawing.Size(160, 24);
            this.cmbRolUsuario.TabIndex = 13;
            this.cmbRolUsuario.SelectedIndexChanged += new System.EventHandler(this.RolUsuario_SelectedIndexChanged);
            // 
            // LblTelUsuario
            // 
            this.LblTelUsuario.AutoSize = true;
            this.LblTelUsuario.Location = new System.Drawing.Point(325, 99);
            this.LblTelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelUsuario.Name = "LblTelUsuario";
            this.LblTelUsuario.Size = new System.Drawing.Size(61, 16);
            this.LblTelUsuario.TabIndex = 14;
            this.LblTelUsuario.Text = "Teléfono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(325, 178);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(137, 16);
            this.lblFechaNacimiento.TabIndex = 15;
            this.lblFechaNacimiento.Text = "Fecha De Nacimiento";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(325, 242);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 16);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Nombre de Usuario";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Location = new System.Drawing.Point(325, 317);
            this.lblRolUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(28, 16);
            this.lblRolUsuario.TabIndex = 17;
            this.lblRolUsuario.Text = "Rol";
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(212, 486);
            this.btnLimpiarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(133, 28);
            this.btnLimpiarUsuario.TabIndex = 18;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnVolverCrearUsuario
            // 
            this.btnVolverCrearUsuario.Location = new System.Drawing.Point(415, 486);
            this.btnVolverCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolverCrearUsuario.Name = "btnVolverCrearUsuario";
            this.btnVolverCrearUsuario.Size = new System.Drawing.Size(133, 28);
            this.btnVolverCrearUsuario.TabIndex = 19;
            this.btnVolverCrearUsuario.Text = "Volver";
            this.btnVolverCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNuevoUsuario.Location = new System.Drawing.Point(31, 31);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(241, 29);
            this.lblNuevoUsuario.TabIndex = 20;
            this.lblNuevoUsuario.Text = "Crear nuevo usuario";
            // 
            // frmCreacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 554);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.btnVolverCrearUsuario);
            this.Controls.Add(this.btnLimpiarUsuario);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.LblTelUsuario);
            this.Controls.Add(this.cmbRolUsuario);
            this.Controls.Add(this.txtMailUsuario);
            this.Controls.Add(this.dtpFechaNacimientoUsuario);
            this.Controls.Add(this.txtTelefonoUsuario);
            this.Controls.Add(this.lblDocUsuario);
            this.Controls.Add(this.lblMailUsuario);
            this.Controls.Add(this.lblApellidoUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.txtDocumentoUsuario);
            this.Controls.Add(this.txtUsernameUsuario);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreacionUsuario";
            this.Text = "Crear usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtUsernameUsuario;
        private System.Windows.Forms.TextBox txtDocumentoUsuario;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.Label lblMailUsuario;
        private System.Windows.Forms.Label lblDocUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoUsuario;
        private System.Windows.Forms.TextBox txtMailUsuario;
        private System.Windows.Forms.ComboBox cmbRolUsuario;
        private System.Windows.Forms.Label LblTelUsuario;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Button btnVolverCrearUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
    }
}
