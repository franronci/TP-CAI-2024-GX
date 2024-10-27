using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Persistencia.Utils;
using Newtonsoft.Json;
using System.IO;
using Datos;

namespace Persistencia
{
    public class ClienteWS
    {
        //Obtiene una lista de clientes desde el servicio web.
        public List<ClienteWS> getClientes()
        {
            //Define una ruta (path) para la API
            String path = "/api/Cliente/GetClientes";

            List<ClienteWS> clientes = new List<ClienteWS>();
            try
            {
                //Realiza una solicitud HTTP GET utilizando un helper (WebHelper.Get).
                HttpResponseMessage response = WebHelper.Get(path);

                //Si la respuesta es exitosa (IsSuccessStatusCode), lee el contenido de la respuesta y deserializa el JSON en una lista de objetos Cliente.
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ClienteWS> listadoClientes = JsonConvert.DeserializeObject<List<ClienteWS>>(contentStream);
                    return listadoClientes;
                }

                //Si hay un error en la respuesta o una excepción, se imprime un mensaje en la consola.
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return clientes;

        }

        // Obtiene un cliente específico desde el servicio web por su ID.
        public ClienteWS getClienteById(string idCliente)
        {
            // Define la ruta para la API con el ID del cliente.
            String path = $"/api/Cliente/GetCliente/{idCliente}";

            ClienteWS cliente = null;
            try
            {
                // Realiza una solicitud HTTP GET utilizando un helper (WebHelper.Get).
                HttpResponseMessage response = WebHelper.Get(path);

                // Si la respuesta es exitosa (IsSuccessStatusCode), lee el contenido de la respuesta y deserializa el JSON en un objeto Cliente.
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<ClienteWS>(contentStream);
                }
                else
                {
                    // Imprime un mensaje en la consola si la respuesta contiene un error.
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Muestra cualquier excepción que ocurra durante la solicitud.
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return cliente;



            //Modifica los datos de un cliente existente.
            public void ModificarCliente(Guid idCliente, String direccion, String telefono, String email)
        {
            //Define una ruta para la API que maneja la actualización (PATCH).
            String path = "/api/Cliente/PatchCliente";

            //Crea un diccionario con los datos del cliente que se quieren modificar.
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idCliente.ToString());
            map.Add("direccion", direccion);
            map.Add("telefono", telefono);
            map.Add("email", email);

            //Serializa este diccionario a JSON
            var jsonRequest = JsonConvert.SerializeObject(map);

            //Envía una solicitud PATCH a la API. Maneja la respuesta de manera similar a getClientes, imprimiendo mensajes de error si la respuesta no es exitosa.
            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        //Agrega un nuevo cliente.
        public void AgregarCliente(AltaCliente altaCliente)
        {
            //Define la ruta para la API que agrega un cliente (POST).
            String path = "/api/Cliente/AgregarCliente";

            //Serializa el objeto altaCliente en formato JSON y lo envía a la API.
            var jsonRequest = JsonConvert.SerializeObject(altaCliente);

            //Maneja la respuesta, imprimiendo cualquier mensaje de error si es necesario.
            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        //Elimina un cliente existente.
        public void BorrarCliente(Guid idCliente)
        {
            //Define la ruta de la API para la eliminación (DELETE), incluyendo el idCliente como un parámetro de consulta.
            String path = "/api/Cliente/BajaCliente?id=" + idCliente;

            //Envía la solicitud DELETE y maneja la respuesta de manera similar a los métodos anteriores.
            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
