﻿using Datos;
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

        public List<UsuarioWSDatos> buscarDatosUsuario(String idUsuario)
        {
            List<UsuarioWSDatos> clientes = new List<UsuarioWSDatos>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWSDatos> listadoClientes = JsonConvert.DeserializeObject<List<UsuarioWSDatos>>(contentStream);
                return listadoClientes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los usuarios");
            }

        }

        public string altaUsuario(String idAdmin, int host, String nombre, String apellido, int dni, string direccion, string telefono, string email,
                        string fechaNacimiento, string nombreUsuario, string contraseña)
        {
            var datos = new
            {
                idUsuario = idAdmin,               
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

    
            HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonData);

            if (response.IsSuccessStatusCode)
            {
                return "Usuario creado exitosamente.";
            }
            else
            {
                return $"Error al crear usuario: Código {(int)response.StatusCode} - {response.ReasonPhrase}";

            }
        }

        public string bajaUsuario(String idAdmin, String idUsuario)
        {
            try
            {
                
                string url = "https://cai-tp.azurewebsites.net/api/Usuario/BajaUsuario";

                
                Dictionary<string, string> datos = new Dictionary<string, string>
                {
                    { "id", idUsuario },
                        { "idUsuario", idAdmin }
                };
                var jsonData = JsonConvert.SerializeObject(datos);

                
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete, 
                    RequestUri = new Uri(url),
                    Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
                };

                HttpResponseMessage response = WebHelper.httpClient.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    return "Usuario dado de baja exitosamente.";
                }
                else
                {
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
            catch (Exception ex)
            {
                return $"Excepción al realizar la solicitud DELETE: {ex.Message}";
            }
        }


        public string reactivarUsuario(string id, string idUsuario)
        {
        
            var datos = new
            {
                id = id,
                idUsuario = idUsuario
            };

            
            var jsonData = JsonConvert.SerializeObject(datos);

                       
            HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonData);

           
            if (response.IsSuccessStatusCode)
            {
                return "Usuario reactivado exitosamente.";
            }
            else
            {
                throw new Exception("Error al reactivar al usuario.");
            }
        }


        public string cambiarContraseña(String nombreUsuario,String contraseña, String contraseñaNueva)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>
            {
                { "nombreUsuario", nombreUsuario },
                { "contraseña", contraseña },
                { "contraseñaNueva", contraseñaNueva }
            };

            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonData);

            if (response.IsSuccessStatusCode)
            {
                return "Contraseña cambiada exitosamente.";
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return "Error al cambiar la contraseña del usuario.";
            }
        }



    }
}