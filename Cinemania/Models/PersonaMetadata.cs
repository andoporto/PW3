using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class PersonaMetadata
    {
        [Required]       
        private int cod { get; set; }
        [Required]    
        private string nombre { get; set; }
        [Required]     
        private string apellido { get; set; }
        [Required]
        public string email { get; set; }
        [Required]      
        private string nombreLogin { get; set; }
        [Required]       
        public string claveLogin { get; set; }
        [Required]
        private Boolean privilegio { get; set; }
    }
}