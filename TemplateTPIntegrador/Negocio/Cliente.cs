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
        private String id = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void agregarCliente(string idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            AltaCliente altaCliente = new AltaCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, "1");
            clienteServicio.AgregarCliente(altaCliente);
        }

        public void modificarCliente(Guid id, string direccion, string telefono, string email)
        {
            clienteServicio.ModificarCliente(id, direccion, telefono, email);
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
