using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength (maximumLength: 50, ErrorMessage = "El campo {0} no debe tener más de {1} caracteres")]
        public string? CiPersona { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Apellidos { get; set; }
        public string? Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
