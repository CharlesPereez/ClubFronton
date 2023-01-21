using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Producto
    {
        public int ProductoId { get; set; }
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Stock { get; set; }
        public int? CategoriaId { get; set; }
        public int? ProveedorId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual Proveedor? Proveedor { get; set; }
    }
}
