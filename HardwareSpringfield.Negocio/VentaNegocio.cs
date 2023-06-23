using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
    public class VentaNegocio
    {
        private readonly VentaDatos ventaDatos;

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

        public List<Venta> VentasPorProducto(int idProducto)
        {
            List<Venta> ventas = ventaDatos.TraerTodos();
            List<Venta> ventasPorProducto = new List<Venta>();

            foreach(Venta v in ventas)
            {
                if (v.IdProducto == idProducto)
                {
                    ventasPorProducto.Add(v);
                }
            }

            return ventasPorProducto;
        }
    }
}
