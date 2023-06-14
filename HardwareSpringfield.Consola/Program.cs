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
        static void Main(string[] args)
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
        }

        class Validaciones
        {
            private const string _errorDatosNoCargados = "Los datos aun no fueron cargados. Presione una tecla para volver";

            public static string ErrorDatosNoCargados
            {
                get { return _errorDatosNoCargados; }
            }
            public static int PedirInt(string mensaje, int min, int max)
            {
                bool valido = false;
                string mensError = "Debe ingresar un valor entre " + min + " y " + max;
                int valor;
                do
                {
                    Console.WriteLine(mensaje);
                    if (!int.TryParse(Console.ReadLine(), out valor))
                    {
                        Console.WriteLine(mensError);
                    }
                    else
                    {
                        if (valor < min || valor > max)
                        {
                            Console.WriteLine(mensError);
                        }
                        else
                        {
                            valido = true;
                        }
                    }
                } while (!valido);
                return valor;
            }
            public static string PedirStr(string mensaje)
            {
                string valor;
                do
                {
                    Console.WriteLine(mensaje);
                    valor = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        Console.WriteLine("Este campo no puede ser vacio");
                    }
                } while (string.IsNullOrWhiteSpace(valor));

                return valor;
            }
            public static float PedirFloat(string mensaje, float min, float max)
            {
                bool valido = false;
                string mensError = "Debe ingresar un valor entre " + min + " y " + max;
                float valor;
                do
                {
                    Console.WriteLine(mensaje);
                    if (!float.TryParse(Console.ReadLine(), out valor))
                    {
                        Console.WriteLine(mensError);
                    }
                    else
                    {
                        if (valor < min || valor > max)
                        {
                            Console.WriteLine(mensError);
                        }
                        else
                        {
                            valido = true;
                        }
                    }
                } while (!valido);
                return valor;
            }
        }

    }
}
