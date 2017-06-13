using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Cinemania.Models;

namespace Cinemania.Models
{
    [MetadataType(typeof(PeliculaMetadata))]
    public class Pelicula
    {
       
    }

    public enum clasificacion
    {
        ATP,
        May13,
        May13R,
        May16,
        May16R
    }

    public enum genero
    {
        Terror,
        Thriller,
        Accion,
        Comedia,
        ComediaR
    }
}