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
    public class ProductoWS
    {
        public void AgregarProducto(AltaProducto altaProducto)
        {
            //Define la ruta para la API que agrega un producto (POST).
            String path = "/api/Producto/AgregarProducto";

            //Serializa el objeto altaProveedor en formato JSON y lo envía a la API.
            var jsonRequest = JsonConvert.SerializeObject(altaProducto);

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
        public List<DatosProductoWS> getProductos()
        {
            //Define una ruta (path) para la API
            String path = "/api/Producto/TraerProductos";

            List<DatosProductoWS> productos = new List<DatosProductoWS>();
            try
            {
                //Realiza una solicitud HTTP GET utilizando un helper (WebHelper.Get).
                HttpResponseMessage response = WebHelper.Get(path);

                //Si la respuesta es exitosa (IsSuccessStatusCode), lee el contenido de la respuesta y deserializa el JSON en una lista de objetos Cliente.
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<DatosProductoWS> listadoProductos = JsonConvert.DeserializeObject<List<DatosProductoWS>>(contentStream);
                    return listadoProductos;
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
            return productos;

        }
        public List<DatosProductoWS> getProductosByCategoria(int idCategoria)
        {
            List<DatosProductoWS> productos = new List<DatosProductoWS>();

            // Cambiar 'id' por 'catnum' en el parámetro de la URL
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductosPorCategoria?catnum=" + idCategoria);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<DatosProductoWS> productosCategoria = JsonConvert.DeserializeObject<List<DatosProductoWS>>(contentStream);
                return productosCategoria;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los productos por categoría");
            }
        }

        public void ModificarProducto(string idProducto, string idUsuario, int Precio, int Stock)
        {
            //Define una ruta para la API que maneja la actualización (PATCH).
            String path = "/api/Producto/ModificarProducto";

            //Crea un diccionario con los datos del producto que se quieren modificar.
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProducto.ToString());
            map.Add("idUsuario", idUsuario.ToString());
            map.Add("Precio", Precio.ToString());
            map.Add("Stock", Stock.ToString());

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

        public void bajaProducto(string idProducto)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProducto.ToString());
            map.Add("idUsuario", "70b37dc1-8fde-4840-be47-9ababd0ee7e5");

            var jsonRequest = JsonConvert.SerializeObject(map);

            String path = "/api/Producto/BajaProducto";

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

        public void reactivarProducto(String idProducto)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>
            {
                { "idUsuario", idProducto }
            };

            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.Patch("Producto/ReactivarProducto", jsonData);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Producto reactivado exitosamente.");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al reactivar al Producto.");
            }
        }
    }
}
