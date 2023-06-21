using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System;
using System.Collections.Generic;

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

        public void CrearCliente(Cliente cliente)
        {
            clienteDatos.Insertar(cliente);
        }

        public Cliente ObtenerClientePorId(int idCliente)
        {
            if (idCliente == 0) return null;

            List<Cliente> clientes = TraerClientes();
            return clientes.Find(cliente => cliente.Id == idCliente);
        }
    }
}
