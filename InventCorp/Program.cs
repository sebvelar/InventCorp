// See https://aka.ms/new-console-template for more information
using InventCorp;

SistemaLogistica sistemaLogistica = new SistemaLogistica();
CarteraClientes carteraClientes = new CarteraClientes();
Inventario inventario = new Inventario();

bool continuar = true;
do
{
    try
    {
        Console.WriteLine("*** Seleccione una opcion ***");
        Console.WriteLine("1- Administrar Cartera de Clientes");
        Console.WriteLine("2- Registrar Venta");
        Console.WriteLine("3- Administrar Inventario");
        Console.WriteLine("4- Programar Envios");
        Console.WriteLine("5- Salir");
        string opcionMenu = Console.ReadLine();
        Console.Clear();
        switch (opcionMenu)
        {
            case "1":
                Console.WriteLine("--- Administracion de Cartera ---");
                Console.WriteLine("1- Agregar Cliente");
                Console.WriteLine("2- Actualizar Cliente");
                Console.WriteLine("3- Eliminar Cliente");
                Console.WriteLine("4- Mostrar la cartera de clientes");
                Console.WriteLine("5- Volver al Menu");
                string opcionCartera = Console.ReadLine();
                switch (opcionCartera)
                {
                    case "1":
                        Console.WriteLine("Escriba el nombre");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Escriba el apellido");
                        string Apellido = Console.ReadLine();
                        Console.WriteLine("Escriba la cedula");
                        string Cedula = Console.ReadLine();
                        Console.WriteLine("Escriba el Email");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Escriba el telefono");
                        string Telefono = Console.ReadLine();
                        Console.WriteLine("Escriba el año de nacimiento");
                        int AnioNacimiento = int.Parse(Console.ReadLine());
                        carteraClientes.AgregarCliente(new Clientes
                        { 
                            Nombre = Nombre,
                            Apellido = Apellido,
                            Cedula = Cedula,
                            Email = Email,
                            Telefono = Telefono,
                            AnioNacimiento = AnioNacimiento
                        });

                        break;
                    case "2":
                        Console.WriteLine("Escriba la cedula");
                        string newCedula = Console.ReadLine();
                        Console.WriteLine("Escriba el nombre");
                        string newNombre = Console.ReadLine();
                        Console.WriteLine("Escriba el apellido");
                        string newApellido = Console.ReadLine();
                        Console.WriteLine("Escriba el Email");
                        string newEmail = Console.ReadLine();
                        Console.WriteLine("Escriba el telefono");
                        string newTelefono = Console.ReadLine();
                        Console.WriteLine("Escriba el año de nacimiento");
                        int newAnioNacimiento = int.Parse(Console.ReadLine());
                        carteraClientes.ActualizarCliente(newCedula, new Clientes
                        {
                            Nombre = newNombre,
                            Apellido = newApellido,
                            Cedula = newCedula,
                            Email = newEmail,
                            Telefono = newTelefono,
                            AnioNacimiento = newAnioNacimiento
                        });

                        break;
                    case "3":
                        Console.WriteLine("Digite el numero de cedula para eliminar el cliente");
                        string cedulaDelete = Console.ReadLine();
                        carteraClientes.EliminarCliente(cedulaDelete);



                        break;
                    case "4":
                        carteraClientes.MostrarTodosLosClientes();
                        break;
                    default:
                        break;
                }

                break;

            case "2":
                break;
            case "3":
                Console.WriteLine("--- Administracion de Inventario ---");
                Console.WriteLine("1- Agregar Producto");
                Console.WriteLine("2- Actualizar Producto");
                Console.WriteLine("3- Eliminar Producto");
                Console.WriteLine("4- Mostrar el inventario");
                Console.WriteLine("5- Volver al Menu");
                string opcionInventario = Console.ReadLine();
                switch (opcionInventario)
                {
                    case "1":
                        Console.WriteLine("Escriba el nombre");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Escriba las existencias");
                        int Existencias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el tipo producto (Perecederos , No Perecederos)");
                        string tipoProducto = Console.ReadLine();
                        Console.WriteLine("Escriba el Precio");
                        decimal Precio = decimal.Parse(Console.ReadLine());
                        inventario.AgregarProducto(new Producto
                        {
                            nombre = Nombre,
                            existencias = Existencias,
                            tipoProducto = tipoProducto,
                            precio = Precio
                        });


                        break;
                    case "2":
                        Console.WriteLine("Escriba el nombre");
                        string newNombre = Console.ReadLine();
                        Console.WriteLine("Escriba las existencias");
                        int newExistencias = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el tipo producto (Perecederos , No Perecederos)");
                        string newtipoProducto = Console.ReadLine();
                        Console.WriteLine("Escriba el Email");
                        decimal newPrecio = decimal.Parse(Console.ReadLine());
                        inventario.ActualizarProducto(newNombre, new Producto
                        {
                            nombre = newNombre,
                            existencias = newExistencias,
                            precio = newPrecio
                        });

                        break;



                    case "3":
                        Console.WriteLine("Digite el nombre de producto para eliminar");
                        string productoDelete = Console.ReadLine();
                        inventario.EliminarProducto(productoDelete);
                        break;


                    case "4":
                        inventario.MostrarTodosLosProductos();
                        break;
                    default:
                        break;
                }
                break;

            case "4":
                Console.WriteLine("--- Administracion de Envios ---");
                Console.WriteLine("1- Crear un Envio");
                Console.WriteLine("2- Actualizar Estado de Envio");
                Console.WriteLine("3- Buscar Envio");
                Console.WriteLine("4- Mostrar todos los envios");
                Console.WriteLine("5- Volver al Menu");
                string opcionLogistica = Console.ReadLine();
                Console.Clear();
                switch (opcionLogistica)
                {
                    case "1":
                        Console.WriteLine("Digite el Numero de Envio");
                        string NumeroEnvio = Console.ReadLine();
                        Console.WriteLine("Digite el nombre del destinatario");
                        string Destinatario = Console.ReadLine();
                        Console.WriteLine("Digite la direccion de Envio");
                        string Direccion = Console.ReadLine();
                        string Estado = "Procesando";
                        Console.WriteLine("Digite como quiere el tipo de envio");
                        Console.WriteLine("1- Aereo");
                        Console.WriteLine("2- Terrestre");
                        string tipoEnvio = Console.ReadLine();
                        switch (tipoEnvio)
                        {
                            case "1":
                                Console.WriteLine("Digite el numero de Vuelo del Envio");
                                int NumeroVuelo = int.Parse(Console.ReadLine());
                                sistemaLogistica.AgregarEnvio(new EnvioAereo(NumeroEnvio, Destinatario, Direccion, Estado, NumeroVuelo));
                                Console.WriteLine("\n\n");
                                break;

                            case "2":
                                Console.WriteLine("Digite el numero de Camion para el Envio");
                                string NumeroCamion = Console.ReadLine();
                                sistemaLogistica.AgregarEnvio(new EnvioTerrestre(NumeroEnvio, Destinatario, Direccion, Estado, NumeroCamion));
                                Console.WriteLine("\n\n");
                                break;


                            default:
                                break;
                        }


                        break;

                    case "2":

                        Console.WriteLine("Digite el Numero de envio para actualizar estado");
                        string searchNumeroEnvio = Console.ReadLine();
                        Console.WriteLine("Digite el nuevo estado para el envio (Procesando, En tránsito, Entregado)");
                        string nuevoEstadoEnvio = Console.ReadLine();
                        sistemaLogistica.ActualizaEstadoEnvio(searchNumeroEnvio, nuevoEstadoEnvio);
                        break;

                    case "3":
                        Console.WriteLine("Digite el Numero de envio para actualizar estado");
                        string lookNumeroEnvio = Console.ReadLine();
                        sistemaLogistica.BuscarEnvio(lookNumeroEnvio);
                        break;


                    case "4":
                        sistemaLogistica.MostrarTodosLosEnvios();
                        break;
                    default:
                        break;
                }

                break;
            default:
                break;
        }
    }


    catch (Exception e)
    {

        Console.WriteLine($"Ha ocurrido un error. Error {e.Message}");
    }
}
while (continuar);