using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Class1
    {
        public void HacerLogin(string username, string password)
        {

            UsuariosWS usuarios = new UsuariosWS();

            try
            {
                usuarios.login(username, password);
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error durante el login: " + ex.Message);
       
            }

        }




    }
}
