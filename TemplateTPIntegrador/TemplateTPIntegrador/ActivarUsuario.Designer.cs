namespace TemplateTPIntegrador
{
    partial class ActivarUsuario
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
            this.lblusuarioActivar = new System.Windows.Forms.Label();
            this.btnactivarUsuario = new System.Windows.Forms.Button();
            this.txtactivarUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusuarioActivar
            // 
            this.lblusuarioActivar.AutoSize = true;
            this.lblusuarioActivar.Location = new System.Drawing.Point(177, 145);
            this.lblusuarioActivar.Name = "lblusuarioActivar";
            this.lblusuarioActivar.Size = new System.Drawing.Size(43, 13);
            this.lblusuarioActivar.TabIndex = 0;
            this.lblusuarioActivar.Text = "Usuario";
            this.lblusuarioActivar.Click += new System.EventHandler(this.lblusuarioActivar_Click);
            // 
            // btnactivarUsuario
            // 
            this.btnactivarUsuario.Location = new System.Drawing.Point(166, 245);
            this.btnactivarUsuario.Name = "btnactivarUsuario";
            this.btnactivarUsuario.Size = new System.Drawing.Size(64, 23);
            this.btnactivarUsuario.TabIndex = 1;
            this.btnactivarUsuario.Text = "Activar Usuario";
            this.btnactivarUsuario.UseVisualStyleBackColor = true;
            this.btnactivarUsuario.Click += new System.EventHandler(this.btnactivarUsuario_Click);
            // 
            // txtactivarUsuario
            // 
            this.txtactivarUsuario.Location = new System.Drawing.Point(150, 176);
            this.txtactivarUsuario.Name = "txtactivarUsuario";
            this.txtactivarUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtactivarUsuario.TabIndex = 2;
            // 
            // ActivarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.txtactivarUsuario);
            this.Controls.Add(this.btnactivarUsuario);
            this.Controls.Add(this.lblusuarioActivar);
            this.Name = "ActivarUsuario";
            this.Text = "ActivarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuarioActivar;
        private System.Windows.Forms.Button btnactivarUsuario;
        private System.Windows.Forms.TextBox txtactivarUsuario;
    }
}