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
            Console.WriteLine("Hola Mundo,");

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clienteNegocio.crearCliente();
            List<Cliente> clientes = clienteNegocio.TraerClientes();
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
            Thread.Sleep(2500);

            Console.WriteLine("Bienvenido a SpringField - Venta de Hardware!\n");
            MenuPrincipal();
            Console.ReadKey();
        }
            public static void MenuPrincipal()
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("0 - Salir del sistema");
                Console.WriteLine("1 - Menu Cliente");
                Console.WriteLine("2 - Menu Productos");

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
            Console.WriteLine($"Usuario: Cliente - numero {jefe_De_Catedra.NroLegajo}\n");
            Console.WriteLine("0 - Volver al menu principal");
            Console.WriteLine("1 -");
            Console.WriteLine("2 - l");
            Console.WriteLine("3 -");
            Console.WriteLine("4 -");

            int valor;
            valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
            Console.Clear();
            switch (valor)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    //cliente.ListarDatos(DatosAlumnos);
                    Console.Clear();
                    break;
                case 2:
                    // jefe_De_Catedra.Cant(DatosAlumnos);
                    Console.Clear();
                    break;
                case 3:
                    //jefe_De_Catedra.EditarAlumno(DatosAlumnos);
                    Console.Clear();
                    break;
                case 4:
                    //jefe_De_Catedra.BuscarRegistro(DatosAlumnos);
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
                Console.WriteLine($"Usuario: Cliente - numero {jefe_De_Catedra.NroLegajo}\n");
                Console.WriteLine("0 - Volver al menu principal");
                Console.WriteLine("1 -");
                Console.WriteLine("2 - l");
                Console.WriteLine("3 -");
                Console.WriteLine("4 -");

                int valor;
                valor = Validaciones.PedirInt("\nSeleccione una opcion:", 0, 4);
                Console.Clear();
                switch (valor)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        //cliente.ListarDatos(DatosAlumnos);
                        Console.Clear();
                        break;
                    case 2:
                        // jefe_De_Catedra.Cant(DatosAlumnos);
                        Console.Clear();
                        break;
                    case 3:
                        //jefe_De_Catedra.EditarAlumno(DatosAlumnos);
                        Console.Clear();
                        break;
                    case 4:
                        //jefe_De_Catedra.BuscarRegistro(DatosAlumnos);
                        Console.Clear();
                        break;
                }
            }
        }
    }
