using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.SqlServer.Management.Smo;

namespace ProyectoTienda.Models
{
    public class InfoUsuario
    {
        [ForeignKey("Informacion")]
        public int InformacionId { get; set; }
        public Informacion Informaciones { get; set; }

        [ForeignKey("Login")]
        public int LoginId { get; set; }
        public Login Login { get; set; }
    }
}
