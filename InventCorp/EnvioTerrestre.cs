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
