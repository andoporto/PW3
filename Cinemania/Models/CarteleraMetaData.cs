using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class CarteleraMetaData
    {
        [Required]
        public int cod { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = " El {0} debe tener entre 10 y 50 caracteres")]
        public string nombre { get; set; }
        [Required]
        public string calificacion { get; set; }
        [Required]
        public string genero { get; set; }
        [Required]
        public string duracion { get; set; }
    }
}