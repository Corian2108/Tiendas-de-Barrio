using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class DireccionCliente
    {
        [ForeignKey("Direccion")]
        public int ProductosId { get; set; }
        public Direccion Direccion { get; set; }

        [ForeignKey("Clientes")]
        public int ClientesId { get; set; }
        public CompraCliente Clientes { get; set; }
    }
}
