namespace TemplateTPIntegrador
{
    partial class pantallaPrinicpalSupervisor
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
            this.btnaltaProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btndevolucion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPERVISOR";
            // 
            // btnaltaProductos
            // 
            this.btnaltaProductos.Location = new System.Drawing.Point(52, 179);
            this.btnaltaProductos.Name = "btnaltaProductos";
            this.btnaltaProductos.Size = new System.Drawing.Size(114, 39);
            this.btnaltaProductos.TabIndex = 1;
            this.btnaltaProductos.Text = "Alta productos";
            this.btnaltaProductos.UseVisualStyleBackColor = true;
            this.btnaltaProductos.Click += new System.EventHandler(this.btnaltaProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Productos";
            // 
            // btnmodificarProducto
            // 
            this.btnmodificarProducto.Location = new System.Drawing.Point(52, 241);
            this.btnmodificarProducto.Name = "btnmodificarProducto";
            this.btnmodificarProducto.Size = new System.Drawing.Size(114, 39);
            this.btnmodificarProducto.TabIndex = 4;
            this.btnmodificarProducto.Text = "Baja y Modificación de productos";
            this.btnmodificarProducto.UseVisualStyleBackColor = true;
            this.btnmodificarProducto.Click += new System.EventHandler(this.btnmodificarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ventas";
            // 
            // btndevolucion
            // 
            this.btndevolucion.Location = new System.Drawing.Point(302, 179);
            this.btndevolucion.Name = "btndevolucion";
            this.btndevolucion.Size = new System.Drawing.Size(114, 39);
            this.btndevolucion.TabIndex = 6;
            this.btndevolucion.Text = "Devolucion";
            this.btndevolucion.UseVisualStyleBackColor = true;
            this.btndevolucion.Click += new System.EventHandler(this.btndevolucion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reportes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stock critico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ventas por vendedor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Productos mas vendidos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::TemplateTPIntegrador.Properties.Resources.ELECTROHOGAR_SA_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(619, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pantallaPrinicpalSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndevolucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnmodificarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaltaProductos);
            this.Controls.Add(this.label1);
            this.Name = "pantallaPrinicpalSupervisor";
            this.Text = "pantallaPrinicpalSupervisor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaltaProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmodificarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}