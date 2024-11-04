﻿using System;
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
        int _precio;
        int _stock;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        public DatosProductoWS()
        {
        }
        public DatosProductoWS(string nombre, int precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public String ToString()
        {
            return this.Nombre + " (" + this.Precio + ")";
        }
    }
}