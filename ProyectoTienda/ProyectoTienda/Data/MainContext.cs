using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoTienda.Models;

namespace ProyectoTienda.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public DbSet<CompraCliente> CompraCliente { get; set; }

        public DbSet<DueñoTienda> DueñoTienda { get; set; }
    }
}
