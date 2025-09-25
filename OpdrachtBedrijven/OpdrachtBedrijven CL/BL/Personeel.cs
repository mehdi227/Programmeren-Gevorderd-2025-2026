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
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0) throw new BedrijfException("id mag niet 0 of kleiner zijn");
            }
        }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@")) throw new BedrijfException("geen geldig email");
            }
        }
        private DateTime _geboortedatum;
        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set
            {
                DateTime birthday = value;
            }
        }
        private Adres _adres;

        public Personeel(int id, string voornaam, string achternaam, string email, DateTime geboortedatum, Adres adres)
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Geboortedatum = geboortedatum;
            Adres = adres;
        }

        public Adres Adres
        {
            get { return _adres; }
            set
            {
                if (value == null) throw new BedrijfException("adres is null");
            }
        }
    }
}
