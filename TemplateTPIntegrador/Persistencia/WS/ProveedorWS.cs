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
        public void AgregarProveedor(AltaProveedor altaProveedor)
        {
            //Define la ruta para la API que agrega un proveedor (POST).
            String path = "/Proveedor/AgregarProveedor";

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
        public void ModificarProveedor(string idProveedor, string idUsuario, string Nombre, string Apellido, string email, string CUIT)
        {
            //Define una ruta para la API que maneja la actualización (PATCH).
            String path = "/Proveedor/ModificarProveedor";

            //Crea un diccionario con los datos del proveedor que se quieren modificar.
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", "70b37dc1-8fde-4840-be47-9ababd0ee7e5");
            map.Add("nombre", Nombre);
            map.Add("apellido", Apellido);
            map.Add("email", email);
            map.Add("cuit", CUIT);

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
        
        public void bajaProveedor(string idProveedor)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", "70b37dc1-8fde-4840-be47-9ababd0ee7e5");

            var jsonRequest = JsonConvert.SerializeObject(map);

            String path = "/Proveedor/BajaProveedor";

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
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
        public List<DatosProveedorWS> TraerProveedores()
        {
            //Define una ruta (path) para la API
            String path = "/Proveedor/TraerProveedores";

            List<DatosProveedorWS> proveedores = new List<DatosProveedorWS>();
            try
            {
                //Realiza una solicitud HTTP GET utilizando un helper (WebHelper.Get).
                HttpResponseMessage response = WebHelper.Get(path);

                //Si la respuesta es exitosa (IsSuccessStatusCode), lee el contenido de la respuesta y deserializa el JSON en una lista de objetos Cliente.
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<DatosProveedorWS> listadoClientes = JsonConvert.DeserializeObject<List<DatosProveedorWS>>(contentStream);
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
        public void ReactivarProveedor(String idProveedor)
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
    }
}
