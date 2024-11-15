using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProductoWS
    {
        int _idCategoria;
        Guid _id;
        String _nombre;
        double _precio;
        int _stock;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        public DatosProductoWS()
        {
        }
        public DatosProductoWS(Guid Id, int idCategoria, string nombre, DateTime fechaAlta, DateTime fechaBaja, double precio, int stock)
        {
            _id = Id;
            _idCategoria = idCategoria;
            _nombre = nombre;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
            _precio = precio;
            _stock = stock;
        }

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
    }
}
