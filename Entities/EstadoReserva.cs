using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class EstadoReserva
    {
        public EstadoReserva()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int EstadoReservaId { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
