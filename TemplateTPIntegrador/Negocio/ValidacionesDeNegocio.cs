using System;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class ValidacionesDeNegocio
    {


        //Metodo que validar que el largo del texto ingresado esta en 8 y 15 caracteres

        public bool ValidarLargoUserPass(string texto_ingresado)
        {

            int largo_texto = texto_ingresado.Length;

            if (largo_texto < 8 | largo_texto > 15)
            {
                return true;
            }
            return false;
        }


        //Metodo que valida que el usuario no contenga ni el nombre ni el apellido
        public bool ValidarNombreApellido (string nombre, string apellido, string usuario_ingresado)
        {

            if (usuario_ingresado.Contains(nombre) || usuario_ingresado.Contains(apellido))
            {
                return true; 
            }

            return false;
        }
    
        //CONTRASEÑA: En todos si está ok, devuelve true, sino devuelve false

        // 1. Validar solo la longitud de 8 a 15 caracteres
            public bool ValidarLongitudContraseña(string password)
            {
                // Verifica que la contraseña tenga entre 8 y 15 caracteres
                return password.Length >= 8 && password.Length <= 15;
            }

        // 2. Validar que contenga al menos una letra mayúscula, un número, y letras
            public bool ValidarMayusculaYNumero(string password)
            {
                // Verifica que la contraseña incluya al menos una letra mayúscula, un número y letras en general
                return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-zA-Z])");
            }

       // 3. Validar que la contraseña haya expirado (han pasado al menos 30 días desde el último cambio)
            public bool ValidarExpiracion(DateTime fechaUltimoCambio)
            {
                // Calcula los días transcurridos desde el último cambio y devuelve true si han pasado 30 días o menos.
                TimeSpan tiempoTranscurrido = DateTime.Now - fechaUltimoCambio;
                return tiempoTranscurrido.Days <= 30;
            }

        // 4. Validar que la nueva contraseña no sea igual a la anterior
            public bool ValidarNoRepetida(string password, string passwordAnterior)
            {
                // Verifica que la nueva contraseña no sea igual a la anterior.
                return password != passwordAnterior;
            }

        // Método para obtener la fecha del último cambio de contraseña
            public DateTime ObtenerFechaUltimoCambio(string username)
            {
                // Lógica para recuperar la fecha del último cambio de contraseña desde la base de datos o archivo
                // Ejemplo ficticio (en la práctica, debes conectarte a la base de datos o sistema que almacene este dato)
                return DateTime.Now.AddDays(-31); // Ejemplo: Simulando que la contraseña fue cambiada hace 31 días
            }

    }


}

