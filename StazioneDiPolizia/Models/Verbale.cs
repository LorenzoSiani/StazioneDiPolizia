using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StazioneDiPolizia.Models
{
    public class Verbale
    {
        public int Id { get; set; }
        public DateTime DataViolazione { get; set; }
        public string IndirizzoViolazione { get; set; }
        public string NominativoAgente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public double Importo { get; set; }
        public int DecurtamentoPunti { get; set; }
        public int idAnagrafica { get; set; }
        public int idViolazione { get; set;}

        public Verbale (int id, DateTime dataViolazione, string indirizzoViolazione, string nominativoAgente, DateTime dataTrascrizioneVerbale, double importo, int decurtamentoPunti, int idAnagrafica, int idViolazione)
        {
            Id = id;
            DataViolazione = dataViolazione;
            IndirizzoViolazione = indirizzoViolazione;
            NominativoAgente = nominativoAgente;
            DataTrascrizioneVerbale = dataTrascrizioneVerbale;
            Importo = importo;
            DecurtamentoPunti = decurtamentoPunti;
            this.idAnagrafica = idAnagrafica;
            this.idViolazione = idViolazione;
        }
    }
}