using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    internal class CarteraClientes : IClientes
    {
        List<Clientes> Cartera = new List<Clientes>();

        public void ActualizarCliente(string numeroCedula, Clientes cliente)
        {
            foreach (Clientes thisCliente in Cartera)
            {
                if (thisCliente.Cedula.Equals(numeroCedula))
                {
                    thisCliente.Nombre = cliente.Nombre;
                    thisCliente.Apellido = cliente.Apellido;
                    thisCliente.Telefono = cliente.Telefono;
                    thisCliente.Email = cliente.Email;
                    thisCliente.AnioNacimiento = cliente.AnioNacimiento;

                    Console.WriteLine("EL cliente se ha actualizado");
                    return;
                }
            }
            Console.WriteLine("Este cliente no existe por favor intente de nuevo");
        }

        public void AgregarCliente(Clientes cliente)
        {
            Cartera.Add(cliente);
            Console.WriteLine($"El cliente {cliente.Nombre} se ha agregado correctamente");
        }

        public void EliminarCliente(string numeroCedula)
        {
            foreach (Clientes thisCliente in Cartera)
            {
                if (thisCliente.Cedula.Equals(numeroCedula))
                {
                    Cartera.Remove(thisCliente);
                    Console.WriteLine("EL cliente se ha eliminado");
                    return;
                }
            }
            Console.WriteLine("Este cliente no existe por favor intente de nuevo");
        }

        public void MostrarTodosLosClientes()
        {
            Console.WriteLine("---- Informacion de Cartera de Clientes ----\n\n");
            foreach (Clientes thisCliente in Cartera)
            {    
                Console.WriteLine(
                        $"Nombre Completo: {thisCliente.Nombre} {thisCliente.Apellido} \n" +
                        $"Email: {thisCliente.Email} \n" +
                        $"Cedula: {thisCliente.Cedula} \n" +
                        $"Año Nacimiento: {thisCliente.AnioNacimiento}\n" +
                        $"Telefono {thisCliente.Telefono}");
            }
        }
    }
}
