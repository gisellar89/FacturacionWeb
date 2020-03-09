using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFacturaMvc.Models
{
    public class Vendedor
    {
        [ScaffoldColumn(false)]
        public string IdVendedor { get; set; }
        [Required(ErrorMessage = "El campo nombre completo es obligatorio")]
        [DisplayName("Nombre Completo")]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        [DisplayName("Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        [DisplayName("DNI")]
        [StringLength(8)]
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public int Estado { get; set; }
    }
}