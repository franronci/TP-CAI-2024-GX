﻿namespace TemplateTPIntegrador
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

            this.button1 = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();
            this.txtboxUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtboxPasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();

            this.Errores_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(220, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 60);
            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";

            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            //this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // txtboxUsernameLogin
            // 
            this.txtboxUsernameLogin.Location = new System.Drawing.Point(220, 88);
            this.txtboxUsernameLogin.Name = "txtboxUsernameLogin";
            this.txtboxUsernameLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsernameLogin.TabIndex = 2;

            
            //this.txtboxUsernameLogin.TextChanged += new System.EventHandler(this.t);

            // 
            // txtboxPasswordLogin
            // 
            this.txtboxPasswordLogin.Location = new System.Drawing.Point(220, 168);
            this.txtboxPasswordLogin.Name = "txtboxPasswordLogin";
            this.txtboxPasswordLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxPasswordLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 149);
            this.label2.Name = "label2";

            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Errores_login
            // 
            this.Errores_login.ForeColor = System.Drawing.Color.Red;
            this.Errores_login.Location = new System.Drawing.Point(220, 191);
            this.Errores_login.Name = "Errores_login";
            this.Errores_login.Size = new System.Drawing.Size(100, 39);
            this.Errores_login.TabIndex = 6;
            this.Errores_login.Text = "errores";
            this.Errores_login.Visible = false;

            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";

            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.Errores_login);


            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPasswordLogin);
            this.Controls.Add(this.txtboxUsernameLogin);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.btnLogin);

            this.Controls.Add(this.button1);

            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxUsernameLogin;
        private System.Windows.Forms.TextBox txtboxPasswordLogin;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label Errores_login;

    }
}