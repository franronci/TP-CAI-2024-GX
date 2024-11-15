using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;

namespace Negocio
{
    public class Cliente
    {
        private ClienteWS clienteServicio = new ClienteWS();
        private String id = SesionUsuario.IdUsuario;

        public string agregarCliente(string id, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            AltaCliente altaCliente = new AltaCliente(id, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            string respuesta = clienteServicio.AgregarCliente(altaCliente);
            return respuesta;
        }

        public string modificarCliente(Guid id, string direccion, string telefono, string email)
        {
            return (clienteServicio.ModificarCliente(id, direccion, telefono, email));
        }

        public List<DatosClienteWS> listarClientes()
        {
            return clienteServicio.getClientes();
        }

        public void BorrarCliente(Guid idCliente)
        {
            clienteServicio.BorrarCliente(idCliente);
        }
    }
}
