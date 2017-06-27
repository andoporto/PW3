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
        [Required]
        //[RegularExpression(@"^(0[1-9]|1[0-2]):[0-5][0-9] [AP]M$", ErrorMessage = "Se debe seleccionar un horario válido")]
        public string HoraInicio { get; set; }
        public TimeSpan _HoraInicio
        {
            get
            {
                try
                {
                    DateTime dt = DateTime.Parse(HoraInicio);
                    return dt.TimeOfDay;
                }
                catch
                {
                    return new TimeSpan();
                }
            }
        }
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