using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    internal interface IEnvio
    {
        void AgregarEnvio(Envio envio);

        void BuscarEnvio(string numeroEnvio);

        void ActualizaEstadoEnvio(string numeroEnvio, string nuevoEstado);

        void MostrarTodosLosEnvios();

    }
}
