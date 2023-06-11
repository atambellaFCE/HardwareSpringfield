using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Venta
    {
        // ATRIBUTOS     
        private int _id;
        private DateTime _fechaAlta;      
        private Cliente _cliente;
        private Producto _producto;
        private int _cantidad;
        private int _usuario;
        private int _estado;

        //CLIENTE

        // PROPIEDADES      
        public int Id { get => _id; set => _id = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public Cliente Cliente{ get => _cliente; set => _cliente = value; }
        public Producto Producto { get => _producto; set => _producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public int Estado { get => _estado; set => _estado = value; }

        // CONSTRUCTOR
        public Venta(Cliente cliente, Producto producto, int cantidad)
        {
            Id = 1;
            FechaAlta = DateTime.Now;
            Cliente = cliente;
            Producto = producto;
            Cantidad = cantidad;
            Usuario = 889454;
            Estado = 1;
        }

    }
}