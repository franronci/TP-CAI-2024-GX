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
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuarioActivar
            // 
            this.lblusuarioActivar.AutoSize = true;
            this.lblusuarioActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioActivar.Location = new System.Drawing.Point(46, 53);
            this.lblusuarioActivar.Name = "lblusuarioActivar";
            this.lblusuarioActivar.Size = new System.Drawing.Size(74, 24);
            this.lblusuarioActivar.TabIndex = 0;
            this.lblusuarioActivar.Text = "Usuario";
            this.lblusuarioActivar.Click += new System.EventHandler(this.lblusuarioActivar_Click);
            // 
            // btnactivarUsuario
            // 
            this.btnactivarUsuario.Location = new System.Drawing.Point(50, 137);
            this.btnactivarUsuario.Name = "btnactivarUsuario";
            this.btnactivarUsuario.Size = new System.Drawing.Size(64, 23);
            this.btnactivarUsuario.TabIndex = 1;
            this.btnactivarUsuario.Text = "Activar Usuario";
            this.btnactivarUsuario.UseVisualStyleBackColor = true;
            this.btnactivarUsuario.Click += new System.EventHandler(this.btnactivarUsuario_Click);
            // 
            // txtactivarUsuario
            // 
            this.txtactivarUsuario.Location = new System.Drawing.Point(33, 97);
            this.txtactivarUsuario.Name = "txtactivarUsuario";
            this.txtactivarUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtactivarUsuario.TabIndex = 2;
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Location = new System.Drawing.Point(208, 197);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(64, 23);
            this.Boton_Salir.TabIndex = 3;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // ActivarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.txtactivarUsuario);
            this.Controls.Add(this.btnactivarUsuario);
            this.Controls.Add(this.lblusuarioActivar);
            this.Name = "ActivarUsuario";
            this.Text = "Activar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuarioActivar;
        private System.Windows.Forms.Button btnactivarUsuario;
        private System.Windows.Forms.TextBox txtactivarUsuario;
        private System.Windows.Forms.Button Boton_Salir;
    }
}