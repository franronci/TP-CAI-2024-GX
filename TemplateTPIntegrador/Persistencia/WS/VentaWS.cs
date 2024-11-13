using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;

namespace Persistencia
{
    public class VentaWS
    {
        public DatosVentaWS GetVenta()
        {
            String path = "/api/Venta/GetVenta";
            DatosVentaWS venta = null;

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    venta = JsonConvert.DeserializeObject<DatosVentaWS>(contentStream);
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

            return venta;
        }
        public void DevolverVenta(Guid idVenta, Guid idUsuario)
        {
            String path = "/api/Venta/DevolverVenta";
            Dictionary<string, Guid> map = new Dictionary<string, Guid>();
            map.Add("id", idVenta);
            map.Add("idUsuario", idUsuario);

            var jsonRequest = JsonConvert.SerializeObject(map);

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
        public void AgregarVenta(AltaVenta agregarVenta)
        {
            String path = "/Venta/AgregarVenta";

            var jsonRequest = JsonConvert.SerializeObject(agregarVenta);

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

        public List<VentaPorCliente> GetVentasCliente(Guid idCliente)
        {
            String path = "/Venta/GetVentaByCliente?id=" + idCliente;
            List<VentaPorCliente> VentasCliente = new List<VentaPorCliente>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<VentaPorCliente> listadoVentasCliente = JsonConvert.DeserializeObject<List<VentaPorCliente>>(contentStream);
                    return listadoVentasCliente;
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
            return VentasCliente;
        }

    }
}
