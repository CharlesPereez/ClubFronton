using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class EstadoHorario
    {
        public EstadoHorario()
        {
            Horarios = new HashSet<Horario>();
        }

        public int EstadoHorarioId { get; set; }
        public string? Tipo { get; set; }

        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
