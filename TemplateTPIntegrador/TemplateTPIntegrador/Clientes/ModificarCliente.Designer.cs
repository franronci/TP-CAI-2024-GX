namespace TemplateTPIntegrador.Clientes
{
    partial class ModificarCliente
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
            this.LbTelUsuario = new System.Windows.Forms.Label();
            this.TelefonoClienteModif = new System.Windows.Forms.TextBox();
            this.LbApellidoUsuario = new System.Windows.Forms.Label();
            this.direccionClienteModif = new System.Windows.Forms.TextBox();
            this.DNIClienteModif = new System.Windows.Forms.TextBox();
            this.Btnmodificarcliente = new System.Windows.Forms.Button();
            this.txtmailmodif = new System.Windows.Forms.Label();
            this.mailclientemodif = new System.Windows.Forms.TextBox();
            this.Errores1 = new System.Windows.Forms.Label();
            LbNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.Location = new System.Drawing.Point(152, 97);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Size = new System.Drawing.Size(26, 13);
            LbNombreUsuario.TabIndex = 45;
            LbNombreUsuario.Text = "DNI";
            // 
            // LbTelUsuario
            // 
            this.LbTelUsuario.AutoSize = true;
            this.LbTelUsuario.Location = new System.Drawing.Point(152, 253);
            this.LbTelUsuario.Name = "LbTelUsuario";
            this.LbTelUsuario.Size = new System.Drawing.Size(49, 13);
            this.LbTelUsuario.TabIndex = 50;
            this.LbTelUsuario.Text = "Telefono";
            // 
            // TelefonoClienteModif
            // 
            this.TelefonoClienteModif.Location = new System.Drawing.Point(155, 289);
            this.TelefonoClienteModif.Name = "TelefonoClienteModif";
            this.TelefonoClienteModif.Size = new System.Drawing.Size(100, 20);
            this.TelefonoClienteModif.TabIndex = 48;
            // 
            // LbApellidoUsuario
            // 
            this.LbApellidoUsuario.AutoSize = true;
            this.LbApellidoUsuario.Location = new System.Drawing.Point(152, 181);
            this.LbApellidoUsuario.Name = "LbApellidoUsuario";
            this.LbApellidoUsuario.Size = new System.Drawing.Size(52, 13);
            this.LbApellidoUsuario.TabIndex = 46;
            this.LbApellidoUsuario.Text = "Direccion";
            // 
            // direccionClienteModif
            // 
            this.direccionClienteModif.Location = new System.Drawing.Point(155, 206);
            this.direccionClienteModif.Name = "direccionClienteModif";
            this.direccionClienteModif.Size = new System.Drawing.Size(100, 20);
            this.direccionClienteModif.TabIndex = 44;
            // 
            // DNIClienteModif
            // 
            this.DNIClienteModif.Location = new System.Drawing.Point(155, 132);
            this.DNIClienteModif.Name = "DNIClienteModif";
            this.DNIClienteModif.Size = new System.Drawing.Size(100, 20);
            this.DNIClienteModif.TabIndex = 43;
            // 
            // Btnmodificarcliente
            // 
            this.Btnmodificarcliente.Location = new System.Drawing.Point(155, 469);
            this.Btnmodificarcliente.Name = "Btnmodificarcliente";
            this.Btnmodificarcliente.Size = new System.Drawing.Size(100, 23);
            this.Btnmodificarcliente.TabIndex = 51;
            this.Btnmodificarcliente.Text = "Modificar cliente";
            this.Btnmodificarcliente.UseVisualStyleBackColor = true;
            this.Btnmodificarcliente.Click += new System.EventHandler(this.Btnmodificarcliente_Click);
            // 
            // txtmailmodif
            // 
            this.txtmailmodif.AutoSize = true;
            this.txtmailmodif.Location = new System.Drawing.Point(152, 333);
            this.txtmailmodif.Name = "txtmailmodif";
            this.txtmailmodif.Size = new System.Drawing.Size(26, 13);
            this.txtmailmodif.TabIndex = 53;
            this.txtmailmodif.Text = "Mail";
            // 
            // mailclientemodif
            // 
            this.mailclientemodif.Location = new System.Drawing.Point(155, 369);
            this.mailclientemodif.Name = "mailclientemodif";
            this.mailclientemodif.Size = new System.Drawing.Size(100, 20);
            this.mailclientemodif.TabIndex = 52;
            // 
            // Errores1
            // 
            this.Errores1.ForeColor = System.Drawing.Color.Red;
            this.Errores1.Location = new System.Drawing.Point(152, 416);
            this.Errores1.Name = "Errores1";
            this.Errores1.Size = new System.Drawing.Size(100, 23);
            this.Errores1.TabIndex = 54;
            this.Errores1.Text = "errorescliente";
            this.Errores1.Visible = false;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 520);
            this.Controls.Add(this.Errores1);
            this.Controls.Add(this.txtmailmodif);
            this.Controls.Add(this.mailclientemodif);
            this.Controls.Add(this.Btnmodificarcliente);
            this.Controls.Add(this.LbTelUsuario);
            this.Controls.Add(this.TelefonoClienteModif);
            this.Controls.Add(this.LbApellidoUsuario);
            this.Controls.Add(LbNombreUsuario);
            this.Controls.Add(this.direccionClienteModif);
            this.Controls.Add(this.DNIClienteModif);
            this.Name = "ModificarCliente";
            this.Text = "Modificar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTelUsuario;
        private System.Windows.Forms.TextBox TelefonoClienteModif;
        private System.Windows.Forms.Label LbApellidoUsuario;
        private System.Windows.Forms.TextBox direccionClienteModif;
        private System.Windows.Forms.TextBox DNIClienteModif;
        private System.Windows.Forms.Button Btnmodificarcliente;
        private System.Windows.Forms.Label txtmailmodif;
        private System.Windows.Forms.TextBox mailclientemodif;
        private System.Windows.Forms.Label Errores1;
    }
}