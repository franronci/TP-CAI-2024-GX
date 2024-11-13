using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Datos;

namespace Negocio
{
    public class ValidacionesDeNegocio
    {
        public static string EsNombre(string text, string nombreCampo)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(text))
            {
                return $"No se especificó el {nombreCampo}.";
            }

            // Verificar si el texto tiene menos de 3 caracteres
            if (text.Length < 3)
            {
                return $"El {nombreCampo} debe tener al menos 3 caracteres.";
            }

            // Verificar si el texto contiene números
            if (text.Any(char.IsDigit))
            {
                return $"El {nombreCampo} no puede tener números.";
            }

            // Verificar si el texto contiene caracteres especiales excepto espacios
            if (text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return $"El {nombreCampo} no puede tener caracteres especiales."; // Saco al espaciado como "caracter especial".
            }
            // Si pasa todas las condiciones, el texto es válido
            return null; // Retorna null si el nombre es válido
        }

        public static string EsDNI(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo DNI no puede estar vacío.";
            }

            // Verificar si el texto tiene longitud diferente de 8 dígitos
            if (texto.Length != 8)
            {
                return "El campo DNI debe tener exactamente 8 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo DNI debe contener solo dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static string EsCUIT(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo CUIT no puede estar vacío.";
            }

            // Verificar si el texto tiene longitud diferente de 11 dígitos
            if (texto.Length != 11)
            {
                return "El campo CUIT debe tener exactamente 11 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo CUIT debe contener solo dígitos numéricos.";
            }

            // Verificar si el número de CUIT empieza en 2 o en 3
            if (texto[0] != '2' && texto[0] != '3')
            {
                return "El primer dígito del CUIT debe ser 2 o 3.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static string EsEdadLaboral(DateTime fechaNacimiento)
        {
            {
                DateTime fechaHoy = DateTime.Today;// Obtener la fecha de hoy
                if
                (fechaNacimiento >= fechaHoy) // Verificar si la fecha de nacimiento es mayor o igual al día de hoy
                {
                    return
                    "No se puede seleccionar un día posterior a hoy."
                    ;
                }

                else
                {
                    DateTime fechaHace18 = fechaHoy.AddYears(-18);
                    // Calcular fecha de hace 18 años
                    DateTime fechaHace65 = fechaHoy.AddYears(-65);
                    // Calcular fecha de hace 65 años

                    if
                    (fechaNacimiento >= fechaHace18) // Verificar si la fecha de nacimiento está entre hace 18 y hace 65 años

                    {
                        return
                        "No se permite incorporar usuarios menores de edad."
                        ;
                    }

                    else if
                    (fechaNacimiento <= fechaHace65)
                    {
                        return
                        "No se permite incorporar usuarios en edad jubilatoria."
                        ;
                    }

                    else
                    {
                        return
                        null; // Si la fecha de nacimiento cumple con los requisitos, no hay error
                    }
                }
            }
        }

        public static string EsDireccion(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Dirección no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 3 || texto.Length > 50)
            {
                return "El campo Dirección debe tener entre 3 y 50 caracteres.";
            }

            // Verificar si la cadena contiene caracteres especiales
            if (!texto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                return "El campo Dirección no puede contener caracteres especiales.";
            }

            // Si se cumplen todas las condiciones, la calle es válida
            return null;
        }

        public static string EsTelefono(string texto)
        {
            // Verificar si el texto tiene longitud fuera del rango de 8 a 12 dígitos
            if (texto.Length < 8 || texto.Length > 12)
            {
                return "El campo Teléfono debe tener entre 8 y 12 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo Teléfono debe contener únicamente dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static string EsMail(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @G3.com
            string patronCorreo = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string patronDominio = @"@G3\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo es inválido.";
            }

            if (texto.Contains(" "))
            {
                return "El correo no puede contener espacios en blanco.";
            }
            if (!Regex.IsMatch(texto, patronDominio))
            {
                return "El correo debe ser del dominio @G3.com";
            }

            return null;
        }

        public static string CampoEnBlanco(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "1";
            }

            return "0";
        }

        public static int EsID(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return 0; // Devuelve 0 si el texto está vacío
            }

            // Expresión regular para validar un UUID en formato de hash
            string patron = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            // Verifica si el texto coincide con el patrón de expresión regular
            if (Regex.IsMatch(texto, patron))
            {
                return 1; // Devuelve 1 si el texto es un hash UUID válido
            }
            else
            {
                return 2; // Devuelve 2 si el texto no es un hash UUID válido
            }
        }

        public static string EsStock(string valor, string campo)
        {
            // Verificar si el valor está vacío o nulo
            if (string.IsNullOrEmpty(valor))
            {
                return "El campo " + campo + " no puede estar vacío.";
            }

            // Verificar si el valor contiene caracteres no numéricos
            if (!int.TryParse(valor, out _))
            {
                return "El campo " + campo + " no puede contener letras ni caracteres especiales.";
            }

            // Convertir el valor a entero
            int stock = int.Parse(valor);

            // Verificar si el valor es menor o igual a cero
            if (stock <= 0)
            {
                return "El campo " + campo + " debe ser un número positivo.";
            }

            // Verificar si el valor es mayor a 1000
            if (stock > 1000)
            {
                return "El campo " + campo + " no puede ser mayor a 1000.";
            }

            //  Si todas las validaciones pasan, devolver null
            return null;
        }

        public static bool EsStockBajo(int valorMaximo, int valorSeleccionado)
        {
            if (valorMaximo == 0)
            {
                throw new ArgumentException("El valor máximo no puede ser cero.");
            }

            double porcentaje = (double)valorSeleccionado / valorMaximo * 100;
            return porcentaje >= 75;
        }

        public static bool EsStockCritico(DatosProductoWS producto)
        {
            // Determinar el umbral de stock según la categoría
            int umbralStock;
            switch (producto.IdCategoria)
            {
                case 1:
                    umbralStock = 100;
                    break;
                case 2:
                    umbralStock = 200;
                    break;
                case 3:
                    umbralStock = 300;
                    break;
                case 4:
                    umbralStock = 400;
                    break;
                case 5:
                    umbralStock = 500;
                    break;
                default:
                    umbralStock = int.MaxValue; // Valor por defecto si la categoría no coincide con ninguna de las especificadas
                    break;
            }

            // Verificar si el stock es igual o menor al 25% del umbral
            return producto.Stock <= (umbralStock * 0.25);
        }

        public static string EsPrecio(string valor, string campo)
        {
            string error = "";

            if (string.IsNullOrEmpty(valor))
            {
                return "El campo " + campo + " no puede estar vacío.";
            }

            if (!int.TryParse(valor, out int salida))
            {
                error = "El campo " + campo + " no es numérico." + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                error = "El campo " + campo + " no es positivo." + Environment.NewLine;
            }
            else if (salida > 20000000)
            {
                error = "El campo " + campo + " no puede ser superior a 20,000,000." + Environment.NewLine;
            }

            return string.IsNullOrEmpty(error) ? null : error;
        }

        public static string ValidarVacio(string valor, string campo)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return "El campo " + campo + " no puede estar vacío.";
            }
            return null;
        }

        public static string MailProveedor(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @G1.com
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@G3\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo electrónico debe tener el dominio @G3.com.";
            }

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }

            return null;
        }

        public static string MailCliente(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @G1.com
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@G1\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo electrónico debe tener el dominio @G1.com.";
            }

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }

            return null;
        }

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

