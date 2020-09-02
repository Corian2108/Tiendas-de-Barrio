using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class CompraDetalle
    {
        public int Id { get; set; }
        public string DetalleCompra { get; set; }
        public float Precio { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
