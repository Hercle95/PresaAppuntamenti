using System;
using System.Collections.Generic;
using System.Text;

namespace PresaAppuntamenti.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Localita SedeLegale { get; set; }
        public Localita SedeOperativa { get; set; }
        public string PIva { get; set; }
        public string CodFiscale { get; set; }
        public string RagioneSociale { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
