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

        public EnvioAereo(int numeroVuelo)
        {
            NumeroVuelo = numeroVuelo;
        }

        public override void ActualizaEstado(string nuevoEstado)
        {
            throw new NotImplementedException();
        }

        public override void MostrarDetalles()
        {
            throw new NotImplementedException();
        }
    }
}
