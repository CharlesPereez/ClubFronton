using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Empleado
    {
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Clave { get; set; }
        public string? Email { get; set; }
        public int? RolId { get; set; }
        public int? PersonaId { get; set; }

        public virtual Persona? Persona { get; set; }
        public virtual Rol? Rol { get; set; }
    }
}
