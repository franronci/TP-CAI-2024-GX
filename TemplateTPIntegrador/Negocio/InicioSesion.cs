using Persistencia;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class InicioSesion
    {
        public string HacerLogin(string username, string password)
        {
            UsuariosWS usuarios = new UsuariosWS();

            try
            {
                
                string id_usuario = usuarios.login(username, password);

                return id_usuario;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario o contraseña equivocada");
                return null;
            }
        }


        public void GuardarDatos(string id_usuario)
        {
            DBHelper baseDatos = new DBHelper("DatosUsuario");

            string key_llave_id = $"id_usuario_{id_usuario}";
            string key_llave_host = $"host_{id_usuario}";

            baseDatos.Insertar(key_llave_id, id_usuario);

        }

        public string TraerHost(string id_usuario) 
        
        
        {
            return id_usuario;
        
        }

       
    }
}

