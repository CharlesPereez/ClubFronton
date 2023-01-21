using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Reserva
    {
        public Reserva()
        {
            Clientes = new HashSet<Cliente>();
            Horarios = new HashSet<Horario>();
        }

        public int ReservaId { get; set; }
        public DateTime? FechaReserva { get; set; }
        public string? Duracion { get; set; }
        public int? EstadoReservaId { get; set; }
        public int? PersonaId { get; set; }

        public virtual EstadoReserva? EstadoReserva { get; set; }
        public virtual Persona? Persona { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
