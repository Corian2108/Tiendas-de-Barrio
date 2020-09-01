using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class Tienda
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Detalle { get; set; }
        public List<Direccion> Direccion { get; set; } = new List<Direccion>();
    }
}
