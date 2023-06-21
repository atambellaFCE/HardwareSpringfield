using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
    public class VentaNegocio
    {
        private VentaDatos ventaDatos;

        public VentaNegocio()
        {
            ventaDatos = new VentaDatos();
        }
        public List<Venta> TraerVentas()
        {
            List<Venta> ventas = ventaDatos.TraerTodos();

            return ventas;
        }

        public void CrearVenta(Venta venta)
        {
            ventaDatos.Insertar(venta);   
        }
    }
}
