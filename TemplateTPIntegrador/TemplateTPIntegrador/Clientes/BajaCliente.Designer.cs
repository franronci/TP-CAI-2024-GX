namespace TemplateTPIntegrador.Clientes
{
    partial class BajaCliente
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
            System.Windows.Forms.Label LbNombreUsuario;
            this.DNIClienteBaja = new System.Windows.Forms.TextBox();
            this.Errores1 = new System.Windows.Forms.Label();
            this.Btnbajacliente = new System.Windows.Forms.Button();
            LbNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbNombreUsuario
            // 
            LbNombreUsuario.AutoSize = true;
            LbNombreUsuario.Location = new System.Drawing.Point(155, 158);
            LbNombreUsuario.Name = "LbNombreUsuario";
            LbNombreUsuario.Size = new System.Drawing.Size(96, 13);
            LbNombreUsuario.TabIndex = 47;
            LbNombreUsuario.Text = "Documento cliente";
            // 
            // DNIClienteBaja
            // 
            this.DNIClienteBaja.Location = new System.Drawing.Point(151, 195);
            this.DNIClienteBaja.Name = "DNIClienteBaja";
            this.DNIClienteBaja.Size = new System.Drawing.Size(100, 20);
            this.DNIClienteBaja.TabIndex = 46;
            // 
            // Errores1
            // 
            this.Errores1.ForeColor = System.Drawing.Color.Red;
            this.Errores1.Location = new System.Drawing.Point(151, 259);
            this.Errores1.Name = "Errores1";
            this.Errores1.Size = new System.Drawing.Size(100, 23);
            this.Errores1.TabIndex = 56;
            this.Errores1.Text = "errorescliente";
            this.Errores1.Visible = false;
            // 
            // Btnbajacliente
            // 
            this.Btnbajacliente.Location = new System.Drawing.Point(151, 306);
            this.Btnbajacliente.Name = "Btnbajacliente";
            this.Btnbajacliente.Size = new System.Drawing.Size(100, 23);
            this.Btnbajacliente.TabIndex = 55;
            this.Btnbajacliente.Text = "Baja cliente";
            this.Btnbajacliente.UseVisualStyleBackColor = true;
            this.Btnbajacliente.Click += new System.EventHandler(this.Btnbajacliente_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 520);
            this.Controls.Add(this.Errores1);
            this.Controls.Add(this.Btnbajacliente);
            this.Controls.Add(LbNombreUsuario);
            this.Controls.Add(this.DNIClienteBaja);
            this.Name = "BajaCliente";
            this.Text = "Baja Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNIClienteBaja;
        private System.Windows.Forms.Label Errores1;
        private System.Windows.Forms.Button Btnbajacliente;
    }
}