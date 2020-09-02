using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class DetalleCompra
    {
        [ForeignKey("CompraDetalle")]
        public int DetalleCompraId { get; set; }
        public DetalleCompra DetalleCompras { get; set; }

        [ForeignKey("Producto")]
        public int ProductoId { get; set; }
        public Producto Productos { get; set; }
    }
}
