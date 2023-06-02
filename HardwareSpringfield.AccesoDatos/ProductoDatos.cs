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
    public class ProductoDatos
    {
        public List <Producto> TraerTodos()
        {
            string productos = WebHelper.Get("productos");
            List<Producto> resultado = MapList(productos);
            return resultado;
        }
        public Producto Traer(int idProducto)
        {
            string producto = WebHelper.Get("productos/" + idProducto.ToString());
            Producto resultado = MapObj(producto);            
            return resultado;
        }

        private List<Producto> MapList(string json)
        {
            List<Producto> listProductos= JsonConvert.DeserializeObject<List<Producto>>(json); 
            return listProductos;
        }

        private Producto MapObj(string json)
        {
            Producto producto = JsonConvert.DeserializeObject<Producto>(json);
            return producto;
        }
        public TransactionResult Insertar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelper.Post("productos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Producto producto)
        {
            NameValueCollection obj = ReverseMap(producto);

            string json = WebHelper.Put("productos", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Producto producto)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", producto.Codigo.ToString());
            n.Add("Nombre", producto.Descripcion);
            n.Add("Stock", producto.Stock.ToString());
            n.Add("Precio", producto.Precio.ToString());        
            n.Add("Usuario", "889454");
            return n;
        }
    }
}
