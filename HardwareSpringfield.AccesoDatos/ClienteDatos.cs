using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Collections.Specialized;
using HardwareSpringfield.Entidades;
using HardwareSpringfield.AccesoDatos.Utilidades;

namespace HardwareSpringfield.AccesoDatos
{
    public class ClienteDatos : BaseDatos
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/cliente/" + Registro.ToString()); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }
        public Cliente TraerPorTelefono(string telefono)
        {
            string json2 = WebHelper.Get("cliente/" + telefono + "/telefono"); // trae un texto en formato json de una web
            Cliente resultado = MapObj(json2);
            return resultado;
        }


        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
        }

        private Cliente MapObj(string json)
        {
            Cliente lst = JsonConvert.DeserializeObject<Cliente>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.Id.ToString());
            n.Add("Dni", cliente.Dni.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
            n.Add("FechaAlta", cliente.FechaAlta.ToString("yyyy-MM-dd"));
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", cliente.Usuario.ToString());
            n.Add("Host", cliente.Host.ToString());
            return n;
        }
    }
}