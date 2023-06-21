using System;
using System.Collections.Generic;

namespace HardwareSpringfield.Entidades
{
    public class Proveedor : Persona
    {
        // ATRIBUTOS     
        private List<Producto> _productos;
        private long _cuit;
        private int _idProducto;


        // PROPIEDADES      
        public long Cuit { get => _cuit; set => _cuit = value; }
        public List<Producto> Productos { get => _productos; set => _productos = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }


        // CONSTRUCTOR
        public Proveedor(string nombre, string apellido, string email, long cuit) : base(nombre, apellido, email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cuit = cuit;
            Email = email;
            Productos = new List<Producto>();
            FechaAlta = DateTime.Now;
            Usuario = 889454;
            Activo = true;
            Id = 1;
            IdProducto = 0;

        }

        public override string ToString()
        {
            return this.Id + ") " + this.Apellido + ", " + this.Nombre;
        }
    }
}