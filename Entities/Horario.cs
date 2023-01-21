using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Horario
    {
        public Horario()
        {
            Canchas = new HashSet<Cancha>();
        }

        public int HorarioId { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int? ReservaId { get; set; }
        public int? EstadoHorarioId { get; set; }

        public virtual EstadoHorario? EstadoHorario { get; set; }
        public virtual Reserva? Reserva { get; set; }
        public virtual ICollection<Cancha> Canchas { get; set; }
    }
}
