using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class Direccion
    {
        public int Id { get; set; }

        public string CallePrincipal { get; set; }
        public string CalleSecundari { get; set; }
        public string Referencia { get; set; }
        public string Ciudad { get; set; }
    }
}
