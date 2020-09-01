using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class DueñoTienda
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        [NotMapped]
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }

        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Direccion> Direccion { get; set; } = new List<Direccion>();
    }
}
 