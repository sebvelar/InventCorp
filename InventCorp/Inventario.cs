using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InventCorp
{
    internal class Inventario : IProducto
    {
        public List<Producto> Productos = new List<Producto>(); 

        public void ActualizarProducto(string nombreProducto, Producto newProducto)
        {
            foreach (Producto thisProducto in Productos)
            {
                if (thisProducto.nombre.Equals(nombreProducto))
                {
                    thisProducto.nombre = nombreProducto;
                    thisProducto.precio = newProducto.precio;
                    thisProducto.existencias = newProducto.existencias;
                    Console.WriteLine($"El Producto {thisProducto.nombre} se ha actualizado");
                    return;
                }
            }
            Console.WriteLine("Este Producto no existe por favor intente de nuevo");
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            Console.WriteLine($"El producto llamado: {producto.nombre} se ha creado correctamente");
        }

        public void EliminarProducto(string nombreProducto)
        {
            foreach (Producto thisProducto in Productos)
            {
                if (thisProducto.nombre.Equals(nombreProducto))
                {
                    Productos.Remove(thisProducto);
                    Console.WriteLine($"El Producto {nombreProducto} se ha eliminado");
                    return;
                }
            }
            Console.WriteLine("Este Producto no existe por favor intente de nuevo");
        }

        public void MostrarTodosLosProductos()
        {
            Console.WriteLine("---- Informacion de Productos ----\n\n");
            foreach (Producto thisProducto in Productos)
            {
                Console.WriteLine(
                    $"Nombre Producto: {thisProducto.nombre} \n" +
                    $"Precio: {thisProducto.precio.ToString()}\n"+
                    $"Destinatario: {thisProducto.existencias} \n" +
                    $"Direccion: {thisProducto.tipoProducto} \n\n");
            }
        }
    }
}
