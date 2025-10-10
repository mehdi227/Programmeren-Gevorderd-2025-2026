using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBedrijvenCL.Model
{
    public class Persoon
    {
        public Persoon(int id, string voornaam, string achternaam, DateTime geboortedatum, string woonplaats, int postcode, string straatnaam, string huisnummer, string email)
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geboortedatum = geboortedatum;
            Woonplaats = woonplaats;
            Postcode = postcode;
            Straatnaam = straatnaam;
            Huisnummer = huisnummer;
            Email = email;
        }

        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Woonplaats { get; set; }
        public int Postcode { get; set; }
        public string Straatnaam { get; set; }
        public string Huisnummer { get; set; }
        public string Email { get; set; }
    }
}
