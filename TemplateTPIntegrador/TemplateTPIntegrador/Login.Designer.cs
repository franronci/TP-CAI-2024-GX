namespace TemplateTPIntegrador
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblContraseñaLogin = new System.Windows.Forms.Label();
            this.lblLoginIngresar = new System.Windows.Forms.Label();
            this.lblOlvidoContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Location = new System.Drawing.Point(58, 345);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 55);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUsuarioLogin.Location = new System.Drawing.Point(71, 131);
            this.lblUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(60, 18);
            this.lblUsuarioLogin.TabIndex = 1;
            this.lblUsuarioLogin.Text = "Usuario";
            this.lblUsuarioLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(74, 165);
            this.txtUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(132, 22);
            this.txtUsernameLogin.TabIndex = 2;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(74, 271);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(132, 22);
            this.txtPasswordLogin.TabIndex = 3;
            this.txtPasswordLogin.TextChanged += new System.EventHandler(this.txtboxPasswordLogin_TextChanged);
            // 
            // lblContraseñaLogin
            // 
            this.lblContraseñaLogin.AutoSize = true;
            this.lblContraseñaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContraseñaLogin.Location = new System.Drawing.Point(74, 247);
            this.lblContraseñaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaLogin.Name = "lblContraseñaLogin";
            this.lblContraseñaLogin.Size = new System.Drawing.Size(85, 18);
            this.lblContraseñaLogin.TabIndex = 4;
            this.lblContraseñaLogin.Text = "Contraseña";
            this.lblContraseñaLogin.Click += new System.EventHandler(this.lblContraseñaLogin_Click);
            // 
            // lblLoginIngresar
            // 
            this.lblLoginIngresar.AutoSize = true;
            this.lblLoginIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLoginIngresar.Location = new System.Drawing.Point(53, 48);
            this.lblLoginIngresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginIngresar.Name = "lblLoginIngresar";
            this.lblLoginIngresar.Size = new System.Drawing.Size(227, 29);
            this.lblLoginIngresar.TabIndex = 5;
            this.lblLoginIngresar.Text = "Ingresar al sistema";
            this.lblLoginIngresar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblOlvidoContraseña
            // 
            this.lblOlvidoContraseña.AutoSize = true;
            this.lblOlvidoContraseña.Location = new System.Drawing.Point(71, 447);
            this.lblOlvidoContraseña.Name = "lblOlvidoContraseña";
            this.lblOlvidoContraseña.Size = new System.Drawing.Size(133, 16);
            this.lblOlvidoContraseña.TabIndex = 6;
            this.lblOlvidoContraseña.Text = "Olvidé mi contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 554);
            this.Controls.Add(this.lblOlvidoContraseña);
            this.Controls.Add(this.lblLoginIngresar);
            this.Controls.Add(this.lblContraseñaLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblContraseñaLogin;
        private System.Windows.Forms.Label lblLoginIngresar;
        private System.Windows.Forms.Label lblOlvidoContraseña;
    }
}