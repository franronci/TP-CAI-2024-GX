using Microsoft.Bot.Streaming.Payloads;
using Persistencia;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Negocio
{
    public class InicioSesion

    {
        
        public string HacerLogin(string username, string password)
        {
            UsuariosWS usuarios = new UsuariosWS();
            DBHelper baseDatos = new DBHelper("DatosUsuario");
            

            if (existeUsuario(username))
            {

                DBHelper usuarioActivo = new DBHelper("ContadorIntentos");
                string key_llave_username_intentos = username;


                int contador_dato = traer_intentos(username);

                if (contador_dato < 3)
                {
                    try
                    {

                        string id_usuario = usuarios.login(username, password);

                        if(id_usuario != "") 
                        {
                            contador_dato = 0;
                            string contador_BD = contador_dato.ToString();
                            usuarioActivo.Modificar(key_llave_username_intentos, contador_BD);
                            SesionUsuario.IdUsuario = id_usuario;

                        }

                        return id_usuario;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Contraseña erronea");
                        contador_dato = contador_dato + 1;
                        string contador_BD = contador_dato.ToString();
                        usuarioActivo.Modificar(key_llave_username_intentos, contador_BD);
                        return null;
                    }
                }
                else
                {

                    Administrador admin = new Administrador();
                    string id_admin = "94b09224-5702-4bab-8304-7704ee48a386";
                    string id_usuario = admin.traerid(username);

                    usuarioInactivo(username, id_usuario);
                    MessageBox.Show("El usuario esta inactivo");

                    return null;
                }
                

            }

            else 
            {
                MessageBox.Show("El usuario no existe");
                return null;
            }
           
              
        }


        public void GuardarDatos(string id_usuario,string username)
        {
            DBHelper baseDatos = new DBHelper("DatosUsuario");

            string key_llave_id = username;
            
            string key_llave_host = $"{username}_host";
            
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

                if (usuario.Id == id_usuario)
                {
                    return usuario.Perfil;

                }
            }

            return null; 
        }


        public void contadorSesion(string username, int contador_dato)
        {
          
            DBHelper baseDatos = new DBHelper("ContadorIntentos");
            string key_llave_username_intentos = username;
            string cant_string = contador_dato.ToString();
            baseDatos.Insertar(key_llave_username_intentos, cant_string);                 

        }

        public bool existeUsuario(string username)
        {
            UsuariosWS usuarios = new UsuariosWS();
            string id_admin = "94b09224-5702-4bab-8304-7704ee48a386";

            List<Datos.UsuarioWSDatos> lista_usuarios = usuarios.buscarDatosUsuario(id_admin);

            foreach (var usuario in lista_usuarios)
            {
                if (usuario.NombreUsuario == username)
                {
                    return true; 
                }
            }
            return false; 
        }

        public int traer_intentos(string username)
        {
            DBHelper usuarioActivo = new DBHelper("ContadorIntentos");
            string key_llave_username_intentos = username;

            if (usuarioActivo.Buscar(key_llave_username_intentos) == null)
            {
                int contador_dato = 0;
                contadorSesion(username, contador_dato);
                return contador_dato;
            }

            else
            {
                int contador_dato = int.Parse(usuarioActivo.Buscar(key_llave_username_intentos));
                return contador_dato;
            }

        }


        public void usuarioInactivo(string username, string id)
        {

            DBHelper usuarioInactivo = new DBHelper("UsuariosInactivos");
            string key_inactivos = username;

            usuarioInactivo.Insertar(key_inactivos, id);

        }

        public string cambiarContraseña(String nombreUsuario, String viejaContraseña, String nuevaContraseña)
        {
            UsuariosWS usuario = new UsuariosWS();

            return usuario.cambiarContraseña(nombreUsuario, viejaContraseña, nuevaContraseña);

        }

        public bool esPrimeraSesion(string contraseña, string nombre, string apellido, int dni)
        {
            Administrador administrador = new Administrador();

      

            if(contraseña == administrador.crearPasswordDef(nombre,apellido, dni))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
    public static class SesionUsuario
    {
        public static string IdUsuario { get; set; }
    }
}

