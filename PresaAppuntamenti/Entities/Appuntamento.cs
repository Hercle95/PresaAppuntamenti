using System;
using System.Collections.Generic;
using System.Text;

namespace PresaAppuntamenti.Entities
{
    public class Appuntamento
    {
        public  Agente IdAgente { get; }
        //string Cliente.RagioneSociale;
        public Localita IndirizzoAppuntamento { get; set;  }
        string Data;
        //string Cliente.PIva;
        string IdAppuntamento;
        //string Cliente.NumeroTelefono;
        string Esito;
    }
}
