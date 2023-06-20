using HardwareSpringfield.Entidades;
using HardwareSpringfield.Negocio;
using System;
using System.Collections.Generic;

namespace HardwareSpringfield.Consola
{
	public class Validaciones
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

        public static Proveedor PedirProveedor(string mensaje)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
            List<Proveedor> proveedores = proveedorNegocio.TraerProveedores();
            Proveedor proveedor = null;

            bool valido = false;
            int valor;
            string mensError = "Debe ingresar un número de id válido";
            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensError);
                }
                else
                {
                    proveedor = proveedores.Find(p => p.Id == valor);
                    if (proveedor == null)
                    {
                        Console.WriteLine(mensError);
                    }
                    else
                    {
                        valido = true;
                    }
                }
            } while (!valido);
            return proveedor;
        }

        public static bool ConfirmarIngreso(string mensaje)
        {
            bool valido = false;
            string valor;
            bool confirmado = false;
            string indicaciones = "Debe ingresar S para confirmar y N para rechazar";
            do
            {
                Console.WriteLine(mensaje);
                Console.WriteLine(indicaciones);
                valor = Console.ReadLine().ToUpper();
                if (string.IsNullOrWhiteSpace(valor) || (valor != "S" && valor != "N"))
                {
                    Console.WriteLine(indicaciones);
                } else if (valor == "S")
                {
                    confirmado = true;
                    valido = true;
                }else
                {
                    confirmado = false;
                    valido = true;
                }
                
            } while (!valido);
            return confirmado;
        }
    }
}

