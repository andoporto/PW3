using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class Persona
    {
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 10 caracteres")]
        private int cod { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 50 caracteres")]
        private string nombre { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 50 caracteres")]
        private string apellido { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 50 caracteres")]
        public string email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = " El {0} debe tener entre 10 y 20 caracteres")]
        private string nombreLogin { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = " El {0} debe tener entre 10 y 20 caracteres")]
        public string claveLogin { get; set; }
        [Required]
        private Boolean privilegio { get; set; }
    }
}