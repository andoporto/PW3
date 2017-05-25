using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinemania.Models
{
    public class Persona
    {
        private int cod { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string email { get; set; }  
        private string nombreLogin { get; set; }
        private string claveLogin { get; set; }
        private Boolean privilegio { get; set; }
    }
}