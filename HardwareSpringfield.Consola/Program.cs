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


        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a SpringField - Venta de Hardware!\n");

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clienteNegocio.crearCliente();
            List<Cliente> clientes = clienteNegocio.TraerClientes();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadKey();
        }
        public static void MenuPrincipal()
            {

                Console.WriteLine("Menu principal");
                Console.WriteLine("0 - Salir del sistema");
                Console.WriteLine("1 - Menu Cliente");
                Console.WriteLine("2 - Menu Productos");
                Console.WriteLine("1 - Menu Proveedores");
                Console.WriteLine("2 - Menu Reportes Generados");

            int valor;
                valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 2);
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
                if (Cliente == null)
                {
                    Cliente = new Cliente();
                    //cliente.XXX = Validaciones.PedirInt("Por favor ingrese su numero:", 100000, 999999);
                    Console.Clear();
                }
                //Console.WriteLine($"Usuario: Cliente - numero {}\n");
                Console.WriteLine("0 - Volver al menu principal");
                Console.WriteLine("1 - Ingresar Cliente");
                Console.WriteLine("2 - Consultar Clientes");

                int valor;
                valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
                Console.Clear();
                switch (valor)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                    List<Cliente> clientes = ClienteNegocio.TraerClientes();
                    Console.Clear();
                        break;
                    case 2:
                        //Clientes.ConsultarClientes();
                        Console.Clear();
                        break;
                }
            }
            public static void MenuProducto()
            {
                if (Producto == null)
                {
                    Producto = new Producto();
                    //cliente.XXX = Validaciones.PedirInt("Por favor ingrese su numero:", 100000, 999999);
                    Console.Clear();
                }
              
                Console.WriteLine("0 - Volver al menu principal");
                Console.WriteLine("1 - Ingresar Productos");
                Console.WriteLine("2 - Consultar Productos");

                int valor;
                valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
                Console.Clear();
                switch (valor)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        //Ingresar productos;
                        Console.Clear();
                        break;
                    case 2:
                        //Consultar productos;
                        Console.Clear();
                        break;
                }
            }
            public static void MenuProveedores()
            {
                if (Proveedor == null)
                {
                    Producto = new Producto();
                    Console.Clear();
                }
               
                Console.WriteLine("0 - Volver al menu principal");
                Console.WriteLine("1 - Ingresar Proveedores");
                Console.WriteLine("2 - Consultar Proveedores");
           
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
                        //Consultar Proveedores;
                        Console.Clear();
                        break;
                }
            }

        public static void MenuVentas()
        {
            if (Venta == null)
            {
                Venta = new Venta();
                Console.Clear();
            }
            Console.WriteLine("0 - Volver al menu principal");
            Console.WriteLine("1 - Ingresar Ventas");
            Console.WriteLine("2 - Consultar Ventas");

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
                {
                    if (Venta == null)
                    {
                        Venta = new Venta();
                        Console.Clear();
                    }
                    Console.WriteLine("0 - Volver al menu principal");
                    Console.WriteLine("1 - Obtener reporte de ventas por Cliente");
                    Console.WriteLine("2 - Reporte Producto por Proveedor");

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
            }
        }
    }
}