using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InicioSesion
    {
        public string HacerLogin(string username, string password)
        {

            UsuariosWS usuarios = new UsuariosWS();
            string id_usuario = usuarios.login(username, password);
            return id_usuario;

        }
    }
}

