using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public abstract class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; } 
        public int Email { get; set; }
        public string Telefono { get; set; }
        public int AnioNacimiento { get; set; }

    }
}
