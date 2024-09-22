using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Administrador : Usuario
    {
        // Constructor de la subclase que hereda el constructor de la clase Usuario
        public Administrador(int host, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña, string idUsuario) :
            base(host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, idUsuario)
        {
        }

        // Implementación del método abstracto
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Administrador: {Nombre} {Apellido}, DNI: {Dni}, Usuario: {NombreUsuario}");
        }
    }

}
