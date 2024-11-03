namespace TemplateTPIntegrador
{
    partial class pantallaPrinicpalAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnbajausuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Location = new System.Drawing.Point(48, 136);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(258, 99);
            this.btnAltaUsuario.TabIndex = 1;
            this.btnAltaUsuario.Text = "Alta usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnbajausuario
            // 
            this.btnbajausuario.Location = new System.Drawing.Point(48, 274);
            this.btnbajausuario.Name = "btnbajausuario";
            this.btnbajausuario.Size = new System.Drawing.Size(258, 99);
            this.btnbajausuario.TabIndex = 2;
            this.btnbajausuario.Text = "Baja usuario";
            this.btnbajausuario.UseVisualStyleBackColor = true;
            this.btnbajausuario.Click += new System.EventHandler(this.btnbajausuario_Click);
            // 
            // pantallaPrinicpalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbajausuario);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "pantallaPrinicpalAdmin";
            this.Text = "pantallaPrinicpalAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnbajausuario;
    }
}