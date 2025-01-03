﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class ActivarUsuario : Form
    {
        public ActivarUsuario()
        {
            InitializeComponent();
        }

        private void lblusuarioActivar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnactivarUsuario_Click(object sender, EventArgs e)
        {

            Administrador admin = new Administrador();

            string username = txtactivarUsuario.Text;

            MessageBox.Show(admin.activarUsuario(username));

        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir\n\nLos cambios no se guardarán.", "Cancelar activación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
