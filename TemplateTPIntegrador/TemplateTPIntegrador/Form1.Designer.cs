namespace TemplateTPIntegrador
{
    partial class Form1
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
            this.BtnCrearUsuario = new System.Windows.Forms.Button();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.ApellidoUsuario = new System.Windows.Forms.TextBox();
            this.UsernameUsuario = new System.Windows.Forms.TextBox();
            this.ContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCrearUsuario
            // 
            this.BtnCrearUsuario.Location = new System.Drawing.Point(202, 236);
            this.BtnCrearUsuario.Name = "BtnCrearUsuario";
            this.BtnCrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.BtnCrearUsuario.TabIndex = 0;
            this.BtnCrearUsuario.Text = "button1";
            this.BtnCrearUsuario.UseVisualStyleBackColor = true;
            this.BtnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Location = new System.Drawing.Point(202, 81);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.NombreUsuario.TabIndex = 1;
            this.NombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // ApellidoUsuario
            // 
            this.ApellidoUsuario.Location = new System.Drawing.Point(202, 42);
            this.ApellidoUsuario.Name = "ApellidoUsuario";
            this.ApellidoUsuario.Size = new System.Drawing.Size(100, 20);
            this.ApellidoUsuario.TabIndex = 2;
            this.ApellidoUsuario.TextChanged += new System.EventHandler(this.ApellidoUsuario_TextChanged);
            // 
            // UsernameUsuario
            // 
            this.UsernameUsuario.Location = new System.Drawing.Point(202, 131);
            this.UsernameUsuario.Name = "UsernameUsuario";
            this.UsernameUsuario.Size = new System.Drawing.Size(100, 20);
            this.UsernameUsuario.TabIndex = 3;
            this.UsernameUsuario.TextChanged += new System.EventHandler(this.UsernameUsuario_TextChanged);
            // 
            // ContraseñaUsuario
            // 
            this.ContraseñaUsuario.Location = new System.Drawing.Point(202, 173);
            this.ContraseñaUsuario.Name = "ContraseñaUsuario";
            this.ContraseñaUsuario.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaUsuario.TabIndex = 4;
            this.ContraseñaUsuario.TextChanged += new System.EventHandler(this.ContraseñaUsuario_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.ContraseñaUsuario);
            this.Controls.Add(this.UsernameUsuario);
            this.Controls.Add(this.ApellidoUsuario);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.BtnCrearUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.TextBox ApellidoUsuario;
        private System.Windows.Forms.TextBox UsernameUsuario;
        private System.Windows.Forms.TextBox ContraseñaUsuario;
    }
}

