using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Proveedor : Persona
    {
        // ATRIBUTOS     
        private List<Producto> _productos;
        private string _cuit;
        private DateTime _fechaBaja;


        // PROPIEDADES      
        public string Cuit { get => _cuit; set => _cuit = value; }
        public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }


        // CONSTRUCTOR
        public Proveedor(string nombre, string apellido, string email, string cuit) : base(nombre, apellido, email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cuit = cuit;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Productos = new List<Producto>();
            FechaAlta = DateTime.Now;
            Usuario = 889454;
            Activo = true;
            Id = 1;
        }
    }
}