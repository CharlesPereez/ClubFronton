using System;
using System.Collections.Generic;

namespace CRUDPersonas.Entities
{
    public partial class ReservaVenta
    {
        public int? ReservaId { get; set; }
        public int? VentaId { get; set; }

        public virtual Reserva? Reserva { get; set; }
        public virtual Venta? Venta { get; set; }
    }
}
