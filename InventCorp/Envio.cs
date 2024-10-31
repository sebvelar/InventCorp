using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public abstract class Envio
    {
        protected Envio(string numeroEnvio, string destinatario, string direccion, string estado)
        {
            NumeroEnvio = numeroEnvio;
            Destinatario = destinatario;
            Direccion = direccion;
            Estado = estado;
        }

        public string NumeroEnvio { get; set; }

        public string Destinatario { get; set;} 
        public string Direccion { get; set; }
        public string Estado { get; set; }


        public abstract void ActualizaEstado(string nuevoEstado);

        public abstract void MostrarDetalles();


    }
}
