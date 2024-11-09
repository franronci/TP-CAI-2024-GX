using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosVentaWS
    {
        string _id;

        public DatosVentaWS()
        {
        }

        public DatosVentaWS(string id)
        {
            _id = id;
        }
        public string Id { get => _id; set => _id = value; }
    }
}
