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
    public class ProveedorWS
    {
        public void AgregarProveedor (AltaProveedor altaProveedor)
        {
            //Define la ruta para la API que agrega un proveedor (POST).
            String path = "/api/Proveedor/AgregarProveedor";

            //Serializa el objeto altaProveedor en formato JSON y lo envía a la API.
            var jsonRequest = JsonConvert.SerializeObject(altaProveedor);

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
        public void ModificarProveedor(Guid idProveedor, String direccion, String telefono, String email)
        {
            //Define una ruta para la API que maneja la actualización (PATCH).
            String path = "/api/Cliente/PatchCliente";

            //Crea un diccionario con los datos del proveedor que se quieren modificar.
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
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
        public void BajaProveedor(Guid idProveedor)
        {
            //Define la ruta de la API para la eliminación (DELETE), incluyendo el idProveedoor como un parámetro de consulta.
            String path = "/api/Proveedor/BajaProveedor?id=" + idProveedor;

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
        public List<ProveedorWS> TraerProveedores()
        {
            //Define una ruta (path) para la API
            String path = "/api/Proveedor/TraerProveedores";

            List<ProveedorWS> proveedores = new List<ProveedorWS>();
            try
            {
                //Realiza una solicitud HTTP GET utilizando un helper (WebHelper.Get).
                HttpResponseMessage response = WebHelper.Get(path);

                //Si la respuesta es exitosa (IsSuccessStatusCode), lee el contenido de la respuesta y deserializa el JSON en una lista de objetos Cliente.
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ClienteWS> listadoClientes = JsonConvert.DeserializeObject<List<ClienteWS>>(contentStream);
                    return proveedores;
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
            return proveedores;

        }
        public void ReactivarProveedor (String idProveedor)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>
            {
                { "idProveedor", idProveedor }
            };

            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.Patch("Proveedor/ReactivarProveedor", jsonData);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Proveedor reactivado exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al reactivar al Proveedor.");
            }
        }

=======

namespace Persistencia
{
    internal class ProveedorWS
    {
    }
}
