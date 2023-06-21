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
    public class ProveedorDatos : BaseDatos
    {
        public List<Proveedor> TraerTodos()
        {
            string json2 = WebHelper.Get("VentaHardware/Proveedores/" + Registro.ToString()); // trae un texto en formato json de una web
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

            string json = WebHelper.Post("VentaHardware/Proveedores", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Proveedor proveedor)
        {
            NameValueCollection obj = ReverseMap(proveedor);

            string json = WebHelper.Put("VentaHardware/Proveedores", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Proveedor proveedor)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", proveedor.Id.ToString());
            n.Add("Nombre", proveedor.Nombre);
            n.Add("Apellido", proveedor.Apellido);
            n.Add("Email", proveedor.Email);
            n.Add("Cuit", proveedor.Cuit.ToString());
            n.Add("IdProducto", proveedor.IdProducto.ToString());
            n.Add("FechaAlta", proveedor.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("Usuario", proveedor.Usuario.ToString());
            n.Add("Activo", proveedor.Activo.ToString());
            return n;
        }
    }
}
