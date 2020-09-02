using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class ProductosClientes
    {
        [ForeignKey("Productos")]
        public int ProductosId { get; set; }
        public Producto Productos { get; set; }

        [ForeignKey("Clientes")]
        public int ClientesId { get; set; }
        public CompraCliente Clientes { get; set; }
    }
}
