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
        [Key]
        public int IdCartelera { get; set; }
       [Required]        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> IdSede { get; set; }
        [Required]       
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> IdPelicula { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> HoraInicio { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> HoraFin { get; set; }
        [Required]
        public int NumeroSala { get; set; }
    }
}