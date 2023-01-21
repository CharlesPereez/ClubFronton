using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Rol
    {
        public Rol()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int RolId { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
