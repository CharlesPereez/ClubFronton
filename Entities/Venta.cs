using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class Venta
    {
        public int VentaId { get; set; }
        public DateTime? FechaDate { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? MontoFinal { get; set; }
    }
}
