using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuariosWS
    {
        private String adminId = "94b09224-5702-4bab-8304-7704ee48a386";

        public String login(String username, String password)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>();
            datos.Add("nombreUsuario", username);
            datos.Add("contraseña", password);

            // Convert the data to a JSON string
            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonData);

            String idUsuario = "";

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                idUsuario = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento del Login");
            }

            return idUsuario;
        }

        private List<Datos.UsuarioWS> buscarDatosUsuario(String idUsuario)
        {
            List<Datos.UsuarioWS> clientes = new List<Datos.UsuarioWS>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Datos.UsuarioWS> listadoClientes = JsonConvert.DeserializeObject<List<Datos.UsuarioWS>>(contentStream);
                return listadoClientes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los usuarios");
            }

        }

        public void altaUsuario(String idAdmin, int host, String nombre, String apellido, int dni, string direccion, string telefono, string email,
                        string fechaNacimiento, string nombreUsuario, string contraseña)
        {
            var datos = new
            {
                idAdmin = idAdmin,               
                host = host,                     
                nombre = nombre,
                apellido = apellido,
                dni = dni,                        
                direccion = direccion,
                telefono = telefono,
                email = email,
                fechaNacimiento = fechaNacimiento,  
                nombreUsuario = nombreUsuario,
                contraseña = contraseña
            };

            var jsonData = JsonConvert.SerializeObject(datos);

    
            HttpResponseMessage response = WebHelper.Post("Usuario/AltaUsuario", jsonData);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Usuario creado exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al dar de alta al usuario.");
            }
        }

        public void bajaUsuario(String idAdmin, String idUsuario)
        {
            string url = $"Usuario/BajaUsuario?idAdmin={idAdmin}&idUsuario={idUsuario}";

            HttpResponseMessage response = WebHelper.Delete(url);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Usuario dado de baja exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al dar de baja al usuario.");
            }
        }


        public void reactivarUsuario(String idUsuario)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>
            {
                { "idUsuario", idUsuario }
            };

            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonData);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Usuario reactivado exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al reactivar al usuario.");
            }
        }

        public void cambiarContraseña(String nombreUsuario,String  viejaContraseña ,String nuevaContraseña)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>
            {
                { "nombreUsuario", nombreUsuario },
                { "viejaContraseña", viejaContraseña },
                { "nuevaContraseña", nuevaContraseña }
            };

            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonData);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Contraseña cambiada exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al cambiar la contraseña del usuario.");
            }
        }


    }
}