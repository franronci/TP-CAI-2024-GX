using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{   
    //Se intenta respetar tipos de datos provisto en la consigna
    public class ProveedorWS
    {
        Guid _id;
        Guid _idProducto;
        Guid _idUsuario;
        String _nombre;
        String _apellido;
        Int64 _cuit;
        String _email;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        public ProveedorWS()
        {
        }

        public ProveedorWS(string nombre, string apellido, Int64 cuit, string email)
        {
            _nombre = nombre;
            _apellido = apellido;
            _cuit = cuit;
            _email = email;
        }

        public Guid Id { get => _id; set => _id = value; }
        public Guid IdProducto { get => _idProducto; set => _idProducto = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public Int64 Cuit { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Cuit + ")";
        }
    }
}
