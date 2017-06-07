using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class Sala
    {
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 10 caracteres")]
        private int cod { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 10 caracteres")]
        private string nombre { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 10 caracteres")]
        private string direccion { get; set; }
        [Required]
        [Range(150, 300, ErrorMessage = "La precio deb ser de 150 a 300 pesos")]
        private double precioEntrada { get; set; }
    }
}