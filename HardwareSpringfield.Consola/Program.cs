using HardwareSpringfield.Entidades;
using HardwareSpringfield.Negocio;
using System;
using System.Collections.Generic;

namespace HardwareSpringfield.Consola
{
    class Program
    {
        private static ClienteNegocio clienteNegocio;
        private static ProveedorNegocio proveedorNegocio;
        private static VentaNegocio ventaNegocio;
        private static ReporteNegocio reporteNegocio;
        private static ProductoNegocio productoNegocio;


        public static void Main(string[] args)
        {
            clienteNegocio = new ClienteNegocio();
            proveedorNegocio = new ProveedorNegocio();
            ventaNegocio = new VentaNegocio();
            reporteNegocio = new ReporteNegocio();
            productoNegocio = new ProductoNegocio();

            Console.WriteLine("Bienvenido a SpringField - Venta de Hardware!\n");

            MenuPrincipal();

        }
        public static void MenuPrincipal()
        {

            Console.WriteLine("Menu principal");
            Console.WriteLine("1 - Menu Cliente");
            Console.WriteLine("2 - Menu Productos");
            Console.WriteLine("3 - Menu Ventas");
            Console.WriteLine("4 - Menu Proveedores");
            Console.WriteLine("5 - Menu Reportes");
            Console.WriteLine("0 - Salir del sistema");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 5);
            Console.Clear();
            do
            {
                switch (valor)
                {
                    case 0:
                        Console.WriteLine("Muchas gracias por usar el sistema!!\nPresiona una tecla para salir");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case 1:
                        MenuCliente();
                        break;
                    case 2:
                        MenuProducto();
                        break;
                    case 3:
                        MenuVentas();
                        break;
                    case 4:
                        MenuProveedores();
                        break;
                    case 5:
                        MenuReportes();
                        break;
                }
            } while (valor != 0);
        }

        public static void MenuCliente()
        {
            Console.Clear();

            Console.WriteLine("1 - Ingresar Cliente");
            Console.WriteLine("2 - Consultar Clientes");
            Console.WriteLine("0 - Volver al menu principal");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    IngresarCliente();
                    break;
                case 2:
                    MostrarClientes();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void MenuProducto()
        {
            Console.Clear();

            Console.WriteLine("1 - Ingresar Productos");
            Console.WriteLine("2 - Consultar Productos");
            Console.WriteLine("0 - Volver al menu principal");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    IngresarProducto();
                    Console.Clear();
                    break;
                case 2:
                    MostrarProductos();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        public static void MenuProveedores()
        {
            Console.Clear();

            Console.WriteLine("1 - Ingresar Proveedores");
            Console.WriteLine("2 - Consultar Proveedores");
            Console.WriteLine("0 - Volver al menu principal");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    IngresarProveedor();
                    Console.Clear();
                    break;
                case 2:
                    MostrarProveedores();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static void MenuVentas()
        {
            Console.Clear();

            Console.WriteLine("1 - Ingresar Venta");
            Console.WriteLine("2 - Consultar Ventas");
            Console.WriteLine("0 - Volver al menu principal");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    IngresarVenta();
                    Console.Clear();
                    break;
                case 2:
                    MostrarVentas();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public static void MenuReportes()
        {
            Console.Clear();
            Console.WriteLine("1 - Obtener reporte de ventas por Cliente");
            Console.WriteLine("2 - Reporte Producto por Proveedor");
            Console.WriteLine("0 - Volver al menu principal");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    //Reporte ventas por cliente;
                    Console.Clear();
                    break;
                case 2:
                    //Reporte producto por proveedor;
                    Console.Clear();
                    break;
            }

        }

        private static void MostrarClientes()
        {
            List<Cliente> clientes = clienteNegocio.TraerClientes();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        private static void MostrarProveedores()
        {
            List<Proveedor> proveedores = proveedorNegocio.TraerProveedores();
            foreach (Proveedor proveedor in proveedores)
            {
                Console.WriteLine(proveedor);
            }
        }

        private static void MostrarProductos()
        {
            List<Producto> productos = productoNegocio.TraerProductos();
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto);
            }
        }

        private static void MostrarVentas()
        {
            List<Venta> ventas= ventaNegocio.TraerVentas();
            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta);
            }
        }

        private static Cliente IngresarCliente()
        {
            string nombre = Validaciones.PedirStr("Ingrese un nombre para el cliente:");
            string apellido = Validaciones.PedirStr("Ingrese un apellido para el cliente:");
            long dni = Validaciones.PedirLong("Ingrese un DNI para el cliente", 1000000, 99999999);
            string email = Validaciones.PedirEmail("Ingrese un email para el cliente");
            string direccion = Validaciones.PedirStr("Ingrese una dirección para el cliente:");
            string telefono = Validaciones.PedirStr("Ingrese un numero de teléfono para el cliente:"); ;
            DateTime fechaNacimiento = Validaciones.PedirFecha("Ingrese la fecha de nacimiento del cliente en formato \"dd/mm/aaaa\"");
            bool ingresar;

            Cliente cliente = new Cliente(nombre, apellido, email, dni, direccion, telefono, fechaNacimiento);
            Console.Clear();
            Console.WriteLine(cliente.mostrarDatos());
            ingresar = Validaciones.ValidarSN("Está a punto de ingresar el cliente, está de acuerdo?");
            if (ingresar)
            {
                clienteNegocio.CrearCliente(cliente);
                Console.WriteLine("Cliente ingresado correctamente! Pulse una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ha decidido no ingresar el cliente. Pulse una tecla para continuar");
                Console.ReadKey();
                cliente = null;
            }

            return cliente;
        }

        private static void IngresarProducto()
        {
            string nombre = Validaciones.PedirStr("Ingrese un nombre para el producto:");
            int stock = Validaciones.PedirInt("Ingrese el stock del producto:", 1, 9999);
            float precio = Validaciones.PedirFloat("Ingrese el precio del producto:", 0.01F, 10000000000);
            bool ingresar;
            Console.Clear();
            MostrarProveedores();
            Proveedor proveedor = Validaciones.PedirProveedor("Ingrese el id del proveedor del producto de acuerdo al listado anterior:");

            Producto producto = new Producto(nombre, stock, precio, proveedor.Id);
            Console.Clear();
            Console.WriteLine(producto);
            ingresar = Validaciones.ValidarSN("Está a punto de ingresar el producto, está de acuerdo?");
            if (ingresar)
            {
                productoNegocio.CrearProducto(producto);
                Console.WriteLine("Producto ingresado correctamente! Pulse una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ha decidido no ingresar el producto. Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }

        private static void IngresarProveedor()
        {
            bool ingresar;
            string nombre = Validaciones.PedirStr("Ingrese un nombre para el proveedor:");
            string apellido = Validaciones.PedirStr("Ingrese un apellido para el proveedor:");
            string email = Validaciones.PedirEmail("Ingrese un email para el proveedor:");
            long cuit = Validaciones.PedirLong("Ingrese el CUIT del proveedor sin guiones:", 10000000000, 99999999999);

            Proveedor proveedor = new Proveedor(nombre, apellido, email, cuit);
            Console.Clear();
            Console.WriteLine(proveedor);
            ingresar = Validaciones.ValidarSN("Está a punto de ingresar el producto, está de acuerdo?");
            if (ingresar)
            {
                try
                {
                    proveedorNegocio.crearProveedor(proveedor);
                    Console.WriteLine("Proveedor ingresado correctamente! Pulse una tecla para continuar");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Hubo un inconveniente ingresando el proveedor. Por favor intente nuevamente más tarde");
                }
            }
            else
            {
                Console.WriteLine("Ha decidido no ingresar el proveedor. Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }
        private static void IngresarVenta()
        {
            bool ingresar;
            Cliente cliente = null;
            do
            {
                Console.Clear();
                MostrarClientes();
                ingresar = Validaciones.ValidarSN("¿Ya está cargado el cliente?");
                if (ingresar)
                {
                    cliente = Validaciones.PedirCliente("Ingrese el id del cliente de acuerdo al listado anterior:");
                }
                else
                {
                    Console.Clear();
                    cliente = IngresarCliente();
                }

            } while (cliente == null);

            Console.Clear();
            MostrarProductos();
            Producto producto = Validaciones.PedirProducto("Ingrese el id del producto de acuerdo al listado anterior:");

            int cantidad = Validaciones.PedirInt("Ingrese la cantidad de productos vendidos, recuerde que no puede ingresar un número mayor al stock: ", 0, producto.Stock);

            Venta venta = new Venta(cliente.Id, producto.Id, cantidad);

            Console.Clear();
            Console.WriteLine("Producto: " + producto.Nombre + ", Cantidad: " + venta.Cantidad + ", Cliente: " + cliente.Nombre + " " + cliente.Apellido);
            ingresar = Validaciones.ValidarSN("Está a punto de ingresar la venta, está de acuerdo?");
            if (ingresar)
            {
                ventaNegocio.CrearVenta(venta);
                productoNegocio.ActualizarStock(producto, venta.Cantidad);
                Console.WriteLine("Venta ingresada correctamente! Pulse una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ha decidido no ingresar la Venta. Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}