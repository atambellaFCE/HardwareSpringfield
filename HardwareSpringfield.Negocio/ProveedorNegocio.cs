using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
	public class ProveedorNegocio
	{
        private ProveedorDatos proveedorDatos;

        public ProveedorNegocio()
        {
           proveedorDatos = new ProveedorDatos();
        }
        public List<Proveedor> TraerProveedores()
        {
            List<Proveedor> proveedores = proveedorDatos.TraerTodos();

            return proveedores;
        }

        public void crearProveedor()
        {
        }

        public Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            if (idProveedor == 0)
            {
                return null;
            }
            List<Proveedor> proveedores = TraerProveedores();
            return proveedores.Find(proveedor=> proveedor.Id == idProveedor);

        }
    }
}

