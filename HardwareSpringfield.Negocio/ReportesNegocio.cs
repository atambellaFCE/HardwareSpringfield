using System;
namespace HardwareSpringfield.Negocio
{
    public class ReportesNegocio
    {
        public ReporteServicio()
        {
            _clienteServicio = new ClienteNegocio();
            _productoServicio = new ProductoNegocio();
            _ventaServicio = new VentaNegocio();
            _proveedorServicio = new ProveedorNegocio();
        }

        // Atributos
        private readonly ClienteNegocio _clienteServicio;
        private readonly ProductoNegocio _productoServicio;
        private readonly VentaNegocio _ventaServicio;
        private readonly ProveedorNegocio _proveedorServicio;

        // Metodos

        /// <summary>
        /// Devuelve un reporte de todas las ventas correspondientes al TP, clasificadas en base al cliente que las
        /// realizo.
        /// </summary>

        public List<ReporteVentasCliente> ObtenerReporteVentasPorCliente()
        {
            List<Cliente> clientes = _clienteServicio.ObtenerClientes();
            List<Venta> ventas = _ventaServicio.ObtenerVentas();
            List<Producto> productos = _productoServicio.ObtenerProductos();
            List<ReporteVentasCliente> reporteVentasPorCliente = new List<ReporteVentasCliente>();

            foreach (Cliente cliente in clientes)
            {
                List<Venta> ventasAlCliente = ventas.FindAll(venta => venta.IdCliente == cliente.Id);
                if (!ventasAlCliente.Any()) continue; // No incluir al Cliente en el Reporte si no tiene ventas asociadas.

                List<VentaProductoHelper> productosVentasCliente = ReporteHelper.VincularVentasYProductos(ventasAlCliente, productos);

                reporteVentasPorCliente.Add(new ReporteVentasCliente(productosVentasCliente, cliente));
            }

            return reporteVentasPorCliente;
        }
    }
}


