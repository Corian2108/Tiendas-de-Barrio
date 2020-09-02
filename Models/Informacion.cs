using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Models
{
    public class Informacion
    {
        public int Id { get; set; }
        public string NombreTienda { get; set; }
        public char Ruc { get; set; }
        public byte[] Permisos { get; set; }
        public byte[] Foto { get; set; }
        [NotMapped]
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }
        public string EncardadoEm { get; set; }
        public byte[] PcrEm { get; set; }
        public string EncardadoDes { get; set; }
        public byte[] PcrDes { get; set; }
        public string CorreoElectornico { get; set; }
        public string NumeroCelular { get; set; }
        public char Contraseña { get; set; }
        public bool EntregaDomicilio { get; set; }
        public bool ReservaPedido { get; set; }
        public bool transBancaria { get; set; }
        public bool Tarjeta { get; set; }
        public bool Otros { get; set; }
        public bool Efectivo { get; set; }
        public bool FacturaElectronica { get; set; }
        public bool FacturaFisica { get; set; }
        public List<Direccion> Direccion { get; set; } = new List<Direccion>();
    }
}
