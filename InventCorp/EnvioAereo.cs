using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    internal class EnvioAereo : Envio
    {
        public int NumeroVuelo { get; set; }

        public EnvioAereo(string numeroEnvio, string destinatario, string direccion, string estado, int numeroVuelo) : base(numeroEnvio, destinatario, direccion, estado)
        {
            NumeroVuelo = numeroVuelo;
        }


        public override void ActualizaEstado(string nuevoEstado)
        {
            throw new NotImplementedException();
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Numero envio: {NumeroEnvio}, Numero Vuelo: {NumeroVuelo}");
        }
    }
}
