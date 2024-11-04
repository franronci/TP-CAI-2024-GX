using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ProductoWS
    {
        Int64 _idCategoria;
        Guid _idUsuario;
        Guid _idProveedor;
        String _nombre;
        Int64 _precio;
        Int64 _stock;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        public ProductoWS()
        {
        }
        public ProductoWS(string nombre, Int64 precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public Int64 IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Int64 Precio { get => _precio; set => _precio = value; }
        public Int64 Stock { get => _stock; set => _stock = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public String ToString()
        {
            return this.Nombre + " (" + this.Precio + ")";
        }
    }
}
