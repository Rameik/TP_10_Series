using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP10.Models
{
    public class Temporada
    {
        public int IdTemporada {get;set;}
        public int IdSerie {get;set;}
        public int NumeroTemporada {get;set;}
        public string? TituloTemporada {get;set;}
    }
}