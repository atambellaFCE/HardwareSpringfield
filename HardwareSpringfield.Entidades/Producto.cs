using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Producto
    {
        // ATRIBUTOS     
        private int _id;
        private string _nombre;
        private int _stock;
        private double _precio;
        private Proveedor _proveedor;
        private int _usuario;
        private DateTime _fechaAlta;



        // PROPIEDADES      
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public Proveedor Proveedor { get => _proveedor; set => _proveedor = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        // CONSTRUCTOR
        public Producto(string nombre, int stock, double precio, Proveedor proveedor)
        {
            Id = 1;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            Proveedor = proveedor;
            FechaAlta = DateTime.Now;
            Usuario = 889454;

        }

    }
}
