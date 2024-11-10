namespace TemplateTPIntegrador
{
    partial class EliminarUsuario
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
            this.lblusuarioeliminar = new System.Windows.Forms.Label();
            this.btnusuarioeliminar = new System.Windows.Forms.Button();
            this.usuarioEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblusuarioeliminar
            // 
            this.lblusuarioeliminar.AutoSize = true;
            this.lblusuarioeliminar.Location = new System.Drawing.Point(149, 146);
            this.lblusuarioeliminar.Name = "lblusuarioeliminar";
            this.lblusuarioeliminar.Size = new System.Drawing.Size(55, 13);
            this.lblusuarioeliminar.TabIndex = 0;
            this.lblusuarioeliminar.Text = "Username";
            // 
            // btnusuarioeliminar
            // 
            this.btnusuarioeliminar.Location = new System.Drawing.Point(129, 260);
            this.btnusuarioeliminar.Name = "btnusuarioeliminar";
            this.btnusuarioeliminar.Size = new System.Drawing.Size(100, 23);
            this.btnusuarioeliminar.TabIndex = 1;
            this.btnusuarioeliminar.Text = "Eliminar";
            this.btnusuarioeliminar.UseVisualStyleBackColor = true;
            this.btnusuarioeliminar.Click += new System.EventHandler(this.btnusuarioeliminar_Click);
            // 
            // usuarioEliminar
            // 
            this.usuarioEliminar.Location = new System.Drawing.Point(129, 177);
            this.usuarioEliminar.Name = "usuarioEliminar";
            this.usuarioEliminar.Size = new System.Drawing.Size(100, 20);
            this.usuarioEliminar.TabIndex = 2;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.usuarioEliminar);
            this.Controls.Add(this.btnusuarioeliminar);
            this.Controls.Add(this.lblusuarioeliminar);
            this.Name = "EliminarUsuario";
            this.Text = "Eliminar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuarioeliminar;
        private System.Windows.Forms.Button btnusuarioeliminar;
        private System.Windows.Forms.TextBox usuarioEliminar;
    }
}