﻿namespace TemplateTPIntegrador
{
    partial class pantallaPrinicpalVendedor
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
            this.vtnventa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnventasporvendedor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregarcliente = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENDEDOR";
            // 
            // vtnventa
            // 
            this.vtnventa.Location = new System.Drawing.Point(60, 181);
            this.vtnventa.Name = "vtnventa";
            this.vtnventa.Size = new System.Drawing.Size(114, 39);
            this.vtnventa.TabIndex = 1;
            this.vtnventa.Text = "Venta";
            this.vtnventa.UseVisualStyleBackColor = true;
            this.vtnventa.Click += new System.EventHandler(this.vtnventa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reportes";
            // 
            // btnventasporvendedor
            // 
            this.btnventasporvendedor.Location = new System.Drawing.Point(312, 181);
            this.btnventasporvendedor.Name = "btnventasporvendedor";
            this.btnventasporvendedor.Size = new System.Drawing.Size(114, 39);
            this.btnventasporvendedor.TabIndex = 4;
            this.btnventasporvendedor.Text = "Ventas por vendedor";
            this.btnventasporvendedor.UseVisualStyleBackColor = true;
            this.btnventasporvendedor.Click += new System.EventHandler(this.btnventasporvendedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clientes";
            // 
            // btnagregarcliente
            // 
            this.btnagregarcliente.Location = new System.Drawing.Point(547, 181);
            this.btnagregarcliente.Name = "btnagregarcliente";
            this.btnagregarcliente.Size = new System.Drawing.Size(114, 39);
            this.btnagregarcliente.TabIndex = 6;
            this.btnagregarcliente.Text = "Agregar";
            this.btnagregarcliente.UseVisualStyleBackColor = true;
            this.btnagregarcliente.Click += new System.EventHandler(this.btnagregarcliente_Click);
            // 
            // btnmodificarcliente
            // 
            this.btnmodificarcliente.Location = new System.Drawing.Point(547, 270);
            this.btnmodificarcliente.Name = "btnmodificarcliente";
            this.btnmodificarcliente.Size = new System.Drawing.Size(114, 39);
            this.btnmodificarcliente.TabIndex = 7;
            this.btnmodificarcliente.Text = "Modificar";
            this.btnmodificarcliente.UseVisualStyleBackColor = true;
            this.btnmodificarcliente.Click += new System.EventHandler(this.btnmodificarcliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.ELECTROHOGAR_SA_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(620, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pantallaPrinicpalVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnagregarcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnventasporvendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vtnventa);
            this.Controls.Add(this.label1);
            this.Name = "pantallaPrinicpalVendedor";
            this.Text = "pantallaPrinicpalVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vtnventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnventasporvendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregarcliente;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}