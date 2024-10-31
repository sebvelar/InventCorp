using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    internal class EnvioTerrestre : Envio
    {
        public string NumeroCamion { get; set; }

        public EnvioTerrestre(string numeroEnvio, string destinatario, string direccion, string estado, string NumeroCamion ) : base(numeroEnvio, destinatario, direccion, estado)
        {
        }

       

        public override void ActualizaEstado(string nuevoEstado)
        {
            throw new NotImplementedException();
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Numero envio: {NumeroEnvio}, Numero Vuelo: {NumeroCamion}");
        }
    }
}
