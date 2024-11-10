namespace TemplateTPIntegrador.Proveedor
{
    partial class AltaProveedorf
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
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_CUIT = new System.Windows.Forms.Label();
            this.Nombre_Box = new System.Windows.Forms.TextBox();
            this.Apellido_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.CUIT_Box = new System.Windows.Forms.TextBox();
            this.Boton_Confimar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta proveedor";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Location = new System.Drawing.Point(51, 121);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(44, 13);
            this.Nombre_Label.TabIndex = 1;
            this.Nombre_Label.Text = "Nombre";
            this.Nombre_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Location = new System.Drawing.Point(289, 121);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.Label_Apellido.TabIndex = 2;
            this.Label_Apellido.Text = "Apellido";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(51, 251);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(26, 13);
            this.Label_Email.TabIndex = 3;
            this.Label_Email.Text = "Mail";
            // 
            // Label_CUIT
            // 
            this.Label_CUIT.AutoSize = true;
            this.Label_CUIT.Location = new System.Drawing.Point(289, 251);
            this.Label_CUIT.Name = "Label_CUIT";
            this.Label_CUIT.Size = new System.Drawing.Size(25, 13);
            this.Label_CUIT.TabIndex = 4;
            this.Label_CUIT.Text = "Cuit";
            // 
            // Nombre_Box
            // 
            this.Nombre_Box.Location = new System.Drawing.Point(51, 148);
            this.Nombre_Box.Name = "Nombre_Box";
            this.Nombre_Box.Size = new System.Drawing.Size(100, 20);
            this.Nombre_Box.TabIndex = 5;
            // 
            // Apellido_Box
            // 
            this.Apellido_Box.Location = new System.Drawing.Point(292, 148);
            this.Apellido_Box.Name = "Apellido_Box";
            this.Apellido_Box.Size = new System.Drawing.Size(100, 20);
            this.Apellido_Box.TabIndex = 6;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(51, 280);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(100, 20);
            this.Email_Box.TabIndex = 7;
            // 
            // CUIT_Box
            // 
            this.CUIT_Box.Location = new System.Drawing.Point(292, 280);
            this.CUIT_Box.Name = "CUIT_Box";
            this.CUIT_Box.Size = new System.Drawing.Size(100, 20);
            this.CUIT_Box.TabIndex = 8;
            // 
            // Boton_Confimar
            // 
            this.Boton_Confimar.Location = new System.Drawing.Point(54, 365);
            this.Boton_Confimar.Name = "Boton_Confimar";
            this.Boton_Confimar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Confimar.TabIndex = 9;
            this.Boton_Confimar.Text = "Aceptar";
            this.Boton_Confimar.UseVisualStyleBackColor = true;
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Location = new System.Drawing.Point(292, 365);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Boton_Cancelar.TabIndex = 10;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            // 
            // AltaProveedorf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confimar);
            this.Controls.Add(this.CUIT_Box);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Apellido_Box);
            this.Controls.Add(this.Nombre_Box);
            this.Controls.Add(this.Label_CUIT);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.label1);
            this.Name = "AltaProveedorf";
            this.Text = "Alta Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.Label Label_Apellido;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_CUIT;
        private System.Windows.Forms.TextBox Nombre_Box;
        private System.Windows.Forms.TextBox Apellido_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox CUIT_Box;
        private System.Windows.Forms.Button Boton_Confimar;
        private System.Windows.Forms.Button Boton_Cancelar;
    }
}