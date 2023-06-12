using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Cliente : Persona
    {
        // ATRIBUTOS     
        private long _dni;
        private string _direccion;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private string _host;
   
        // PROPIEDADES      
        public long Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Host { get => _host; set => _host = value; }

        // CONSTRUCTOR
        public Cliente(string nombre, string apellido, string email, long dni, string direccion, string telefono, DateTime fechaNacimiento) : base(nombre, apellido, email)
        {

            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = DateTime.Now;
            Activo = true;
            Usuario = 889454;
            Host = "";
            Id = 1;
        }

    }
}
