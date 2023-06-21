using HardwareSpringfield.AccesoDatos.Utilidades;
using HardwareSpringfield.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HardwareSpringfield.AccesoDatos
{
    public class VentaDatos : BaseDatos
    {
        public List<Venta> TraerTodos()
        {
            string ventas = WebHelper.Get("VentaHardware/ventas/" + Registro.ToString());
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
            Venta venta = JsonConvert.DeserializeObject<Venta>(json);
            return venta;
        }
        public TransactionResult Insertar(Venta venta)
        {
            NameValueCollection obj = ReverseMap(venta);

            string json = WebHelper.Post("VentaHardware/ventas", obj);

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
            n.Add("Id", venta.Id.ToString());
            n.Add("IdCliente", venta.IdCliente.ToString());
            n.Add("IdProducto", venta.IdProducto.ToString());
            n.Add("Cantidad", venta.Cantidad.ToString());
            n.Add("Estado", venta.Estado.ToString());
            n.Add("FechaAlta", venta.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("Usuario", venta.Usuario.ToString());
            return n;
        }
    }
}