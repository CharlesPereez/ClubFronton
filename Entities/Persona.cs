using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Persona
    {
        public Persona()
        {
            Clientes = new HashSet<Cliente>();
            Empleados = new HashSet<Empleado>();
            Reservas = new HashSet<Reserva>();
        }

        public int PersonaId { get; set; }
        public string? CiPersona { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
