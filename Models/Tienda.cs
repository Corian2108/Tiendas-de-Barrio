using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class Tienda
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        [NotMapped]
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Detalle { get; set; }
       
    }
}
