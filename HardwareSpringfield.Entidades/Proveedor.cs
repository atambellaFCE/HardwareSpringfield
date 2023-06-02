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
        private int _codigo;
        private List<Producto> _productos;
        private string _cuit;


        // PROPIEDADES      
        public int Codigo { get => _codigo; set => _codigo = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public string Cuit { get => _cuit; set => _cuit = value; }
   


        // CONSTRUCTOR
        public Proveedor(int codigo, string nombre, string apellido, string cuit, string email, DateTime fechaNacimiento) : base(nombre, apellido, email, fechaNacimiento)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = FechaNacimiento;
            Productos = new List<Producto>();
            Cuit = cuit;
            Email = email;
        }
    }
}
