﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaPorCliente
    {
            Guid _id;
            int _cantidad;
            DateTime _fechaAlta;
            int _estado;

            public VentaPorCliente()
            {
            }

            public VentaPorCliente(Guid idVenta, int cantidad, DateTime fechaAlta, int estado)
            {
                _id = idVenta;
                _cantidad = cantidad;
                _fechaAlta = fechaAlta;
                _estado = estado;
            }
            public Guid Id { get => _id; set => _id = value; }
            public int Cantidad { get => _cantidad; set => _cantidad = value; }
            public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
            public int Estado { get => _estado; set => _estado = value;}
    }
}
