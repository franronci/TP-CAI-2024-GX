using Microsoft.Bot.Streaming.Payloads;
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

            string host_BD = TraerHost(id_usuario).ToString();

            baseDatos.Insertar(key_llave_host, host_BD);

        }
        public int? TraerHost(string id_usuario)
        {
            UsuariosWS usuarios = new UsuariosWS();
            string id_admin = "94b09224-5702-4bab-8304-7704ee48a386";

            List<Datos.UsuarioWSDatos> lista_usuarios = usuarios.buscarDatosUsuario(id_admin);

            foreach (var usuario in lista_usuarios)
            {
                // Imprime los datos para depuración
                Console.WriteLine($"ID: {usuario.Id}, Perfil: {usuario.Perfil}, {usuario.NombreUsuario}  {usuario.Nombre}     {usuario.Apellido}");

                if (usuario.Id == id_usuario)
                {
                    return usuario.Perfil; // Devuelve el perfil si encuentra el usuario

                }
            }

            return null; // Retorna null si no encuentra el usuario
        }


    }
}

