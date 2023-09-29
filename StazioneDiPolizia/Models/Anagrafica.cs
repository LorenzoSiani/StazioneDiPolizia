using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StazioneDiPolizia.Models
{
    public class Anagrafica
    {
        
        
            public int Id { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
        public string Cognome { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
            public string Nome { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
            public string Indirizzo { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
            public string Città { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
            public int CAP { get; set; }
        [Required(ErrorMessage = "Questo campo non può essere vuoto")]
            public string Cod_Fis { get; set; }

        public Anagrafica() { }
        public Anagrafica(int id, string cognome, string nome, string indirizzo, string città, int cAP, string cod_Fis)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
            Indirizzo = indirizzo;
            Città = città;
            CAP = cAP;
            Cod_Fis = cod_Fis;
        }
    }
}