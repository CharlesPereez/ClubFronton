using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public int? ReservaId { get; set; }
        public int? PersonaId { get; set; }

        public virtual Persona? Persona { get; set; }
        public virtual Reserva? Reserva { get; set; }
    }
}
