using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AltaVenta
    {
        Guid _idCliente;
        Guid _idUsuario;
        string _idProducto;
        int _cantidad;


        public AltaVenta(Guid idCliente, Guid idUsuario, string idProducto, int cantidad)
        {
            _idCliente = idCliente;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _cantidad = cantidad;
        }

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid IdCliente { get => _idCliente; set => _idCliente = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
