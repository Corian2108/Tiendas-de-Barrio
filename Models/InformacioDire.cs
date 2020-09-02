using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class InformacioDire
    {
        [ForeignKey("Informacion")]
        public int InformacionId { get; set; }
        public Informacion Informacion { get; set; }

        [ForeignKey("Direccion")]
        public int DireccionId { get; set; }
        public Direccion Direccion { get; set; }
    }
}
