using HardwareSpringfield.Entidades;
using HardwareSpringfield.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            reporteNegocio= new ReporteNegocio();
            productoNegocio= new ProductoNegocio();

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
                    //clienteNegocio.IngresarCliente()
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
                    //Ingresar Proveedores;
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
                    //Ingresar Ventas;
                    Console.Clear();
                    break;
                case 2:
                    // Consultar ventas;
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

        private static void IngresarProducto()
        {
            String nombre = Validaciones.PedirStr("Ingrese un nombre para el producto:");
            int stock = Validaciones.PedirInt("Ingrese el stock del producto:", 1, 9999);
            float precio = Validaciones.PedirFloat("Ingrese el precio del producto:", 0.01F, 10000000000);
            bool ingresar;
            Console.Clear();
            MostrarProveedores();
            Proveedor proveedor = Validaciones.PedirProveedor("Ingrese el id del proveedor del producto de acuerdo al listado anterior:");

            Producto producto = new Producto(nombre, stock, precio, proveedor.Id);
            Console.Clear();
            Console.WriteLine(producto);
            ingresar = Validaciones.ConfirmarIngreso("Está a punto de ingresar el producto, está de acuerdo?");
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
    }
}