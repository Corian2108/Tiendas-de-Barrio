using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class ProductoDueño
    {
        [ForeignKey("Productos")]
        public int ProductosId { get; set; }
        public Producto Productos { get; set; }

        [ForeignKey("Dueño")]
        public int ClientesId { get; set; }
        public DueñoTienda Dueño { get; set; }
    }
}
