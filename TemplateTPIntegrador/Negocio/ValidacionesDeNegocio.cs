using System;

namespace Negocio
{
    public class ValidacionesDeNegocio
    {


        //Metodo que validar que el largo del texto ingresado esta en 8 y 15 caracteres

        public Boolean validarLargoUserPass(string texto_ingresado)
        {

            int largo_texto = texto_ingresado.Length;

            if (largo_texto < 8 | largo_texto > 15)
            {
                return true;
            }
            return false;
        }


        //Metodo que valida que el usuario no contenga ni el nombre ni el apellido
        public Boolean validarNombreApellido (string nombre, string apellido, string usuario_ingresado)
        {

            if (usuario_ingresado.Contains(nombre) || usuario_ingresado.Contains(apellido))
            {
                return false; 
            }

            return true;
        }
    }
    }

