using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public abstract class Envio
    {
        public string NumeroEnvio { get; set; }
        public string Destinatario { get; set;} 
        public string Direccion { get; set; }
        public string Estado { get; set; }


        public abstract void ActualizaEstado(string nuevoEstado);

        public abstract void MostrarDetalles();
   



    }
}
