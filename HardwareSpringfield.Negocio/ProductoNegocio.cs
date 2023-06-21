using HardwareSpringfield.AccesoDatos;
using HardwareSpringfield.Entidades;
using System;
using System.Collections.Generic;

namespace HardwareSpringfield.Negocio
{
    public class ProductoNegocio
    {
        private ProductoDatos productoDatos;

        public ProductoNegocio()
        {
            productoDatos = new ProductoDatos();
        }
        public List<Producto> TraerProductos()
        {
            List<Producto> productos = productoDatos.TraerTodos();

            return productos;
        }

        public void CrearProducto(Producto producto)
        {
            productoDatos.Insertar(producto);
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            if (idProducto == 0)
            {
                return null;
            }
            List<Producto> productos = TraerProductos();
            return productos.Find(producto => producto.Id == idProducto);

        }

        public void ActualizarStock(Producto producto, int cantidad)
        {
            if (producto.Stock >= cantidad)
            {
                producto.Stock -= cantidad;
                productoDatos.Actualizar(producto);
            }
            else
            {
                throw new Exception("No hay más stock del producto que desea vender");
            }
           
        }

    }
}

