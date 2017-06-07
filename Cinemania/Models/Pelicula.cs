using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class Pelicula
    {
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = " El {0} debe tener entre 4 y 10 caracteres")]
        private int cod { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = " El {0} debe tener entre 10 y 50 caracteres")]
        private string nombre { get; set; }
        [Required]
        [DisplayName("Calificacion")]
        private string calificacion { get; set; }
        [Required]
        [DisplayName("Genero")]
        private string genero { get; set; }
        [Required]
        [Range(60,300, ErrorMessage = "La duración tiene que ser4 de 60 a 300 minutos")]
        private string duracion { get; set; }
    }
}