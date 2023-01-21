using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class VentaProducto
    {
        public int? VentaId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? MontoTotal { get; set; }

        public virtual Producto? Producto { get; set; }
        public virtual Venta? Venta { get; set; }
    }
}
