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
    }
}
