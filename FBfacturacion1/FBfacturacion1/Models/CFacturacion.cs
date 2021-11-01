using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBfacturacion1.Models
{
    public class CFacturacion
    {
        
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string edad { get; set; }
        [Required]
        public string Direccion { set; get; }
        [Required]

        public string Telefono { set; get; }
        
        
       
       

    }
}
