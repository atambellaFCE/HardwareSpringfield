using HardwareSpringfield.AccesoDatos.Utilidades;
using HardwareSpringfield.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.AccesoDatos
{
    class VentaDatos
    {
        public List<Venta> TraerTodos()
        {
            string ventas = WebHelper.Get("ventas");
            List<Venta> resultado = MapList(ventas);
            return resultado;
        }

        private List<Venta> MapList(string json)
        {
            List<Venta> listVentas = JsonConvert.DeserializeObject<List<Venta>>(json);
            return listVentas;
        }

        private Venta MapObj(string json)
        {
            Venta venta= JsonConvert.DeserializeObject<Venta>(json);
            return venta;
        }
        public TransactionResult Insertar(Venta venta)
        {
            NameValueCollection obj = ReverseMap(venta);

            string json = WebHelper.Post("ventas", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Venta venta)
        {
            NameValueCollection obj = ReverseMap(venta);

            string json = WebHelper.Put("ventas", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Venta venta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", venta.Codigo.ToString());
            n.Add("FechaAlta", venta.FechaDeVenta.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "889454");
            return n;
        }
    }
}
