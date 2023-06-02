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
    class ProveedorDatos
    {
        public List<Proveedor> TraerTodos()
        {
            string json2 = WebHelper.Get("proveedores"); // trae un texto en formato json de una web
            List<Proveedor> resultado = MapList(json2);
            return resultado;
        }

        private List<Proveedor> MapList(string json)
        {
            List<Proveedor> lst = JsonConvert.DeserializeObject<List<Proveedor>>(json); // deserializacion
            return lst;
        }

        private Proveedor MapObj(string json)
        {
            Proveedor lst = JsonConvert.DeserializeObject<Proveedor>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Proveedor proveedor)
        {
            NameValueCollection obj = ReverseMap(proveedor); //serializacion -> json

            string json = WebHelper.Post("proveedores", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Proveedor proveedor)
        {
            NameValueCollection obj = ReverseMap(proveedor);

            string json = WebHelper.Put("proveedores", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Proveedor proveedor)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", proveedor.Codigo.ToString());
            n.Add("Nombre", proveedor.Nombre);
            n.Add("Apellido", proveedor.Apellido);
            n.Add("Email", proveedor.Email);
            n.Add("Cuit", proveedor.Cuit);
            n.Add("Usuario", "889454");
            return n;
        }
    }
}
