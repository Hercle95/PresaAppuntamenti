using System;

namespace PresaAppuntamenti.Entities
{
    public class Localita
    {
        public string Strada { get; set; }
        public string Civico { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }

        public static implicit operator Localita(string v)
        {
            throw new NotImplementedException();
        }
    }
}