using System;

namespace HardwareSpringfield.Entidades
{
    public class Venta
    {
        // ATRIBUTOS     
        private int _id;
        private DateTime _fechaAlta;
        private int _idCliente;
        private int _idProducto;
        private int _cantidad;
        private int _usuario;
        private int _estado;

        // PROPIEDADES      
        public int Id { get => _id; set => _id = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public int Estado { get => _estado; set => _estado = value; }

        // CONSTRUCTOR
        public Venta(int idCliente, int idProducto, int cantidad)
        {
            Id = 1;
            FechaAlta = DateTime.Now;
            IdCliente = idCliente;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Usuario = 889454;
            Estado = 1;
        }

        public override string ToString()
        {
            return this.Id + ") Producto: " + IdProducto + ", Cantidad: " + this.Cantidad + ", Cliente: " + this.IdCliente;
        }
    }
}