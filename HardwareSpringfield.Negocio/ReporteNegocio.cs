using HardwareSpringfield.Entidades;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
    public class ReporteNegocio
    {
        private ClienteNegocio clienteServicio;
        private ProductoNegocio productoServicio;
        private VentaNegocio ventaServicio;
        private ProveedorNegocio proveedorServicio;

        public ReporteNegocio()
        {
            clienteServicio = new ClienteNegocio();
            productoServicio = new ProductoNegocio();
            ventaServicio = new VentaNegocio();
            proveedorServicio = new ProveedorNegocio();
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


