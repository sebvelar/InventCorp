using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    class SistemaLogistica : IEnvio
    {

        public List<Envio> Envios = new List<Envio>();

        public void AgregarEnvio(Envio envio)
        {
            Envios.Add(envio);
            Console.WriteLine($"El envio {envio.NumeroEnvio} con direccion a {envio.Direccion} para el destinatario {envio.Destinatario} se ha enviado correctamente");
        }

        public void BuscarEnvio(string numeroEnvio)
        {
            foreach (Envio thisEnvio in Envios)
            {
                if (thisEnvio.NumeroEnvio.Equals(numeroEnvio))
                {
                    Console.WriteLine(
                        "---- Informacion de Envio ----\n\n" +
                        $"Numero Envio: {thisEnvio.NumeroEnvio} \n" +
                        $"Destinatario: {thisEnvio.Destinatario} \n" +
                        $"Direccion: {thisEnvio.Direccion} \n" +
                        $"Estado: {thisEnvio.Estado}");
                    return;
                }
            }
            Console.WriteLine("No existe ningun Envio con ese codigo, por favor intente de nuevo");
        }

        public void ActualizaEstadoEnvio(string numeroEnvio, string nuevoEstado)
        {
            foreach (Envio thisEnvio in Envios)
            {
                if (thisEnvio.NumeroEnvio.Equals(numeroEnvio))
                {
                    thisEnvio.Estado = nuevoEstado;
                    Console.WriteLine($"El Estado del Envio {thisEnvio.NumeroEnvio} se ha actualizado");
                }
            }
        }

        public void MostrarTodosLosEnvios()
        {
            Console.WriteLine("---- Informacion de Envio ----\n\n");
            foreach (Envio thisEnvio in Envios)
            {
                    Console.WriteLine(
                        $"Numero Envio: {thisEnvio.NumeroEnvio} \n" +
                        $"Destinatario: {thisEnvio.Destinatario} \n" +
                        $"Direccion: {thisEnvio.Direccion} \n" +
                        $"Estado: {thisEnvio.Estado}\n\n");
            }
        }
    }
}
