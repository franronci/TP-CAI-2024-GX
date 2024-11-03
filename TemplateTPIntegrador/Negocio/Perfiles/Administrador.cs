using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Administrador
    {

        public void agregarUsuario(int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, string nacimiento, string nombreusuario)
        {

            UsuariosWS usuarios = new UsuariosWS();

            string password = crearPasswordDef(nombre, apellido, dni);

            string id_usuario = SesionUsuario.IdUsuario;

            string respuesta = usuarios.altaUsuario(id_usuario, host, nombre, apellido, dni, direccion, telefono, email, nacimiento, nombreusuario, password);

            MessageBox.Show(respuesta);

        }


        public string crearPasswordDef(string nombre, string apellido, int dni)
        {
            string primerLetraNombre = nombre.Substring(0, 1).ToUpper();
            string primerLetraApellido = apellido.Substring(0, 1);

            string defaultpassword = primerLetraNombre+primerLetraApellido+dni.ToString();
            return defaultpassword;

        }


        public void eliminarUsuario(string username)
        {
            string id_eliminar = traerid(username);

            UsuariosWS usuariosWS = new UsuariosWS();
            Console.WriteLine(id_eliminar);
             MessageBox.Show(SesionUsuario.IdUsuario);
            string mensaje = usuariosWS.bajaUsuario(SesionUsuario.IdUsuario, id_eliminar);
            
            MessageBox.Show(mensaje);   


        }



        public string traerid(string username)
        {
            UsuariosWS usuarios = new UsuariosWS();
            string id_admin = "94b09224-5702-4bab-8304-7704ee48a386";

            List<Datos.UsuarioWSDatos> lista_usuarios = usuarios.buscarDatosUsuario(id_admin);

            foreach (var usuario in lista_usuarios)
            {
                if (usuario.NombreUsuario == username)
                {
                    return usuario.Id;
                }
            }
            return "este usuario no existe";
        }



    }
}
