using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL.Exceptions;

namespace OpdrachtBedrijven_CL.BL
{
    public class Personeel
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        private DateTime _geboortedatum;
        public DateTime Geboortedatum {
            get { return _geboortedatum; }
            set { 
                
            }
        }
        private Adres _adres;
        public Adres Adres { get { return _adres; }
            set {
                if (value == null) throw new BedrijfException("adres is null");
            }
        }
    }
}
