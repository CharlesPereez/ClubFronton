using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Cancha
    {
        public int CanchaId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? EstadoCancha { get; set; }
        public int? HorarioId { get; set; }

        public virtual Horario? Horario { get; set; }
    }
}
