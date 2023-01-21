using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Productos = new HashSet<Producto>();
        }

        public int ProveedorId { get; set; }
        public string? Nombre { get; set; }
        public string? PaginaWeb { get; set; }
        public string? Direccion { get; set; }
        public string? Teñlefono { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
