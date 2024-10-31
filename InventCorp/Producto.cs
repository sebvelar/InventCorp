using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public class Producto
    {
        public string nombre { get; set; }
        public int existencias { get; set; }
        public string tipoProducto { get; set; }
        public decimal precio { get; set; }
        public decimal peso { get; set; }

        
    }
}
