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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtboxPasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Errores_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(156, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // txtboxUsernameLogin
            // 
            this.txtboxUsernameLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsernameLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtboxUsernameLogin.Location = new System.Drawing.Point(153, 58);
            this.txtboxUsernameLogin.Name = "txtboxUsernameLogin";
            this.txtboxUsernameLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsernameLogin.TabIndex = 3;
            // 
            // txtboxPasswordLogin
            // 
            this.txtboxPasswordLogin.Location = new System.Drawing.Point(153, 126);
            this.txtboxPasswordLogin.Name = "txtboxPasswordLogin";
            this.txtboxPasswordLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxPasswordLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Errores_login
            // 
            this.Errores_login.ForeColor = System.Drawing.Color.Red;
            this.Errores_login.Location = new System.Drawing.Point(153, 162);
            this.Errores_login.Name = "Errores_login";
            this.Errores_login.Size = new System.Drawing.Size(100, 39);
            this.Errores_login.TabIndex = 7;
            this.Errores_login.Text = "errores";
            this.Errores_login.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::TemplateTPIntegrador.Properties.Resources.login2;
            this.ClientSize = new System.Drawing.Size(434, 298);
            this.Controls.Add(this.Errores_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPasswordLogin);
            this.Controls.Add(this.txtboxUsernameLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxUsernameLogin;
        private System.Windows.Forms.TextBox txtboxPasswordLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Errores_login;
    }
}