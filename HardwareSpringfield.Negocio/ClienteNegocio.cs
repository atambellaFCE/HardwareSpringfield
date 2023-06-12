using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos clienteDatos;

        public ClienteNegocio()
        {
            clienteDatos = new ClienteDatos();
        }
        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = clienteDatos.TraerTodos();

            return clientes;    
        }

        public void crearCliente()
        {
            DateTime fechaNac = DateTime.Now;
            Cliente cliente = new Cliente("Test", "Cliente 15", "esteEsUnEmailDeTest@test.com", 37123123, "calle falsa 333", "1123452345", fechaNac);
            clienteDatos.Insertar(cliente);
        }
    }
}
