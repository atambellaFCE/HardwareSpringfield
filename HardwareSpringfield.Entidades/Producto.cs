using System;

namespace HardwareSpringfield.Entidades
{
    public class Producto
    {
        // ATRIBUTOS     
        private int _id;
        private string _nombre;
        private int _stock;
        private double _precio;
        private int _idProveedor;
        private int _usuario;
        private DateTime _fechaAlta;
        private int _idCategoria;



        // PROPIEDADES      
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        // CONSTRUCTOR
        public Producto(string nombre, int stock, double precio, int idProveedor)
        {
            Id = 1;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            IdProveedor = idProveedor;
            FechaAlta = DateTime.Now;
            Usuario = 889454;
            IdCategoria = 1;

        }

        public override string ToString()
        {
            return this.Id + ") " + this.Nombre + " Precio: $" + this.Precio + " Stock: " + this.Stock + " Id proveedor: " + this.IdProveedor;
        }
    }
}