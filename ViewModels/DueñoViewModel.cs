using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.ViewModels
{
    public class DueñoViewModel
    {
        public int Id { get; internal set; }
       
        [Display(Name = "Fotografía")]
        public IFormFile Foto { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
    }
}