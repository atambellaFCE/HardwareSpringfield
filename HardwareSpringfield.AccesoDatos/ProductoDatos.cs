using HardwareSpringfield.AccesoDatos.Utilidades;
using HardwareSpringfield.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Collections.Specialized;

namespace HardwareSpringfield.AccesoDatos
{
    public class ProductoDatos : BaseDatos
    {
        public List <Producto> TraerTodos()
        {
            string productos = WebHelper.Get("VentaHardware/Productos/" + Registro.ToString());
            List<Producto> resultado = MapList(productos);
            return resultado;
        }

        private List<Producto> MapList(string json)
        {
            List<Producto> listProductos= JsonConvert.DeserializeObject<List<Producto>>(json); 
            return listProductos;
        }

        public TransactionResult Insertar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelper.Post("VentaHardware/Productos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelper.Put("VentaHardware/Productos/", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Producto producto)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", producto.Id.ToString());
            n.Add("Nombre", producto.Nombre);
            n.Add("Stock", producto.Stock.ToString());
            n.Add("Precio", producto.Precio.ToString());
            n.Add("IdProveedor", producto.IdProveedor.ToString());
            n.Add("Usuario", producto.Usuario.ToString());
            n.Add("IdCategoria", producto.IdCategoria.ToString());
            n.Add("FechaAlta", producto.FechaAlta.ToString("yyyy-MM-dd"));
            return n;
        }
    }
}