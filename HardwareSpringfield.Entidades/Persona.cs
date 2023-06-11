using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSpringfield.Entidades
{
    public class Persona
    {
        // ATRIBUTOS     
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _email;
        private bool _activo;
        private int _usuario;
        private DateTime _fechaAlta;


        // PROPIEDADES      
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public DateTime FechaAlta{ get => _fechaAlta; set => _fechaAlta = value; }


        // CONSTRUCTOR
        public Persona(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaAlta = DateTime.Now;
            Usuario = 889454;
            Activo = true; 
        }
    }
}

