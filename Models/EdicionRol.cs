using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class EdicionRol
    {
        public IdentityRole Rol { get; set; }
        public IEnumerable<IdentityUser> Miembros { get; set; }
        public IEnumerable<IdentityUser> NoMiembros { get; set; }
    }
}
