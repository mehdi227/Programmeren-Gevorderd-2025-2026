using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL.Exceptions;

namespace OpdrachtBedrijven_CL.BL{
    public class Personeel{
        public Personeel(int id, string voornaam, string achternaam, string email, DateTime geboortedatum, Adres adres)
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Geboortedatum = geboortedatum;
            Adres = adres;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0 || value != null) _id = value;
                else throw new BedrijfException("id invalid");
            }
        }
        private string _voornaam;
        public string Voornaam {
            get { return _voornaam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _voornaam = value;
                else throw new BedrijfException("voornaam invalid");
            }
        }
        private string _achternaam;
        public string Achternaam {
            get { return _achternaam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _achternaam = value;
                else throw new BedrijfException("achternaam invalid");
            }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@")) _email = value;
                else throw new BedrijfException("email invalid");
            }
        }
        private DateTime _geboortedatum;
        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set
            {
                //TODO controleer of personeel ouder is dan 18 jaar
                if () _geboortedatum = value;
                else throw new BedrijfException("geboortedatum invalid");
            }
        }
        private Adres _adres;
        public Adres Adres
        {
            get { return _adres; }
            set
            {
                if (value != null) _adres = value;
                else throw new BedrijfException("adres invalid");
            }
        }
    }
}
