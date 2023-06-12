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
    }
}
