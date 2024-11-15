using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentasTXT

    {
        public DateTime FechaVenta { get; set; }

        public int IdTransaccion { get; set; }

        public string NombreVendedor { get; set; }

        public string NombreCliente { get; set; }

        public List<string> Productos { get; set; } = new List<string>();

        public List<string> Categorias { get; set; }

        public List<int> Cantidades { get; set; }

        public string MontoTotal { get; set; }

    }
}
