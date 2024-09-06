using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesDeNegocio
    {

        public Boolean validarLargoUsuario(string nombreUsuario)
        {

            int largoUsername = nombreUsuario.Length;
            if (largoUsername < 8)
            {
                return true;
            }

            return false;
        }

    }
}
