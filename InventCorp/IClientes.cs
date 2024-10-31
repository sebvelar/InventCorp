using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    internal interface IClientes
    {
        public void AgregarCliente(Clientes cliente);

        public void ActualizarCliente(string numeroCedula,  Clientes cliente);

        public void EliminarCliente(string numeroCedula);

        public void MostrarTodosLosClientes();
    }
}
