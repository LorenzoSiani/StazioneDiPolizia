using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StazioneDiPolizia.Models
{
    public class TipoViolazione
    {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public TipoViolazione() { }

        public TipoViolazione(string descrizione)
        { 
        
            Descrizione = descrizione;
        }
    }
}