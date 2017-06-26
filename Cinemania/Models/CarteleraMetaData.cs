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
        public int IdSede { get; set; }
        [Required]
        public int IdPelicula { get; set; }        
        public DateTime HoraInicio { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> FechaInicio { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public Nullable<System.DateTime> FechaFin { get; set; }
        [Required]
        public int NumeroSala { get; set; }
    }
}