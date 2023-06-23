using HardwareSpringfield.Entidades;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
    public class ReporteNegocio
    {
        private readonly ProductoNegocio productoServicio;
        private readonly VentaNegocio ventaServicio;

        public ReporteNegocio()
        {
            productoServicio = new ProductoNegocio();
            ventaServicio = new VentaNegocio();
        }

        public List<Venta> ReporteVentasPorCliente(int idCliente)
        {
            List<Venta> ventas = ventaServicio.TraerVentas();

            List<Venta> reporteVentas = ventas.FindAll(v => v.IdCliente == idCliente);
            
            return reporteVentas;
        }

        public List <Producto> ReporteProductosPorProveedor(int idProveedor)
        {
            List<Producto> productos = productoServicio.TraerProductos();

            List<Producto> reporteProductos = productos.FindAll(p => p.IdProveedor == idProveedor);

            return reporteProductos;
        }
    }
}


