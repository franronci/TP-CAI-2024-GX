using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public abstract class Producto
    {
        public void NegocioAgregarProducto(Datos.ProductoWS producto)
        {
            if (producto == null) throw new ArgumentNullException(nameof(producto));
            if (string.IsNullOrEmpty(producto.Nombre)) throw new ArgumentException("El nombre del producto es requerido.");
            if (producto.Precio <= 0) throw new ArgumentException("El precio debe ser mayor a cero.");
            producto.FechaAlta = DateTime.Now;
            

        }

        public void ModificarProducto(Datos.ProductoWS producto)
        {
            if (producto == null) throw new ArgumentNullException(nameof(producto));
            if (string.IsNullOrEmpty(producto.Nombre)) throw new ArgumentException("El nombre del producto es requerido.");
             
    }
}
}