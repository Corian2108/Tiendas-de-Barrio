using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class DireccionTienda
    {
        [ForeignKey("Direccion")]
        public int DireccionId { get; set; }
        public Direccion Direcciones { get; set; }

        [ForeignKey("Tienda")]
        public int TiendaId { get; set; }
        public Tienda Tiendas { get; set; }
    }
}
