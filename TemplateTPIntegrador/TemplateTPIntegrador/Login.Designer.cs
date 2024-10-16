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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtboxPasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(293, 304);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxUsernameLogin
            // 
            this.txtboxUsernameLogin.Location = new System.Drawing.Point(293, 108);
            this.txtboxUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxUsernameLogin.Name = "txtboxUsernameLogin";
            this.txtboxUsernameLogin.Size = new System.Drawing.Size(132, 22);
            this.txtboxUsernameLogin.TabIndex = 2;
            // 
            // txtboxPasswordLogin
            // 
            this.txtboxPasswordLogin.Location = new System.Drawing.Point(293, 207);
            this.txtboxPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxPasswordLogin.Name = "txtboxPasswordLogin";
            this.txtboxPasswordLogin.Size = new System.Drawing.Size(132, 22);
            this.txtboxPasswordLogin.TabIndex = 3;
            this.txtboxPasswordLogin.TextChanged += new System.EventHandler(this.txtboxPasswordLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPasswordLogin);
            this.Controls.Add(this.txtboxUsernameLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
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
    }
}