using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Datos;

namespace Negocio
{
    public class Proveedor
    {
        private ProveedorWS ProveedorServicio = new ProveedorWS();
        public String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<DatosProveedorWS> listarProveedores()
        {
            return ProveedorServicio.TraerProveedores();
        }

        public void AgregarProveedor(string idUsuario, string Nombre, string Apellido, string CUIT, string email)
        {
            AltaProveedor altaProveedor = new AltaProveedor(idUsuario, Nombre, Apellido, CUIT, email);
            ProveedorServicio.AgregarProveedor(altaProveedor);
        }

        public void ModificarProveedor(string idProveedor, string idUsuario, string Nombre, string Apellido, string email, string CUIT)
        {
            ProveedorServicio.ModificarProveedor(idProveedor, idUsuario, Nombre, Apellido, email, CUIT);

        }

        public void BorrarProveedor(Guid idProveedor, Guid id_sesion)
        {
            ProveedorServicio.bajaProveedor(idProveedor, id_sesion);
        }
    }
}
