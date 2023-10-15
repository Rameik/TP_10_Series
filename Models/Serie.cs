using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP10.Models
{
    public class Serie
    {
        public int IdSerie {get;set;}
        public string? Nombre {get;set;}
        public int AñoInicio {get;set;}
        public string? Sinopsis {get;set;}
        public string? ImagenSerie {get;set;}
    }
}