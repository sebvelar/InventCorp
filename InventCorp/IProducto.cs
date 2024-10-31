using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    interface IProducto
    {
        public void AgregarProducto(Producto producto);

        public void ActualizarProducto(string nombreProducto, Producto newProducto);

        public void EliminarProducto(string nombreProducto);

        public void MostrarTodosLosProductos();

    }
}
