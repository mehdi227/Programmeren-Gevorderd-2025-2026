using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL.Exceptions;

namespace OpdrachtBedrijven_CL.BL
{
    public class Adres
    {
        public Adres(string woonplaats, string straatnaam, string huisnummer, int postcode)
        {
            List<string> errors = new();
            try { Woonplaats = woonplaats; } catch (BedrijfException ex) { errors.Add(ex.Message); }
            try { Postcode = postcode; } catch (BedrijfException ex) { errors.Add(ex.Message); }
            try { Straatnaam = straatnaam; } catch (BedrijfException ex) { errors.Add(ex.Message); }
            try { Huisnummer = huisnummer; } catch (BedrijfException ex) { errors.Add(ex.Message); }
            if (errors.Count > 0)
            {
                BedrijfException ex = new BedrijfException("adres niet ok");
                ex.Errors = errors;
                throw ex;
            }
        }
        private string _woonplaats;
        public string Woonplaats
        {
            get { return _woonplaats; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) || value.Length >= 3) _woonplaats = value;
                else throw new BedrijfException("woonplaats invalid");
            }
        }
        private int _postcode;
        public int Postcode
        {
            get { return _postcode; }
            set
            {
                if (value >= 1000 && value <= 9000) _postcode = value;
                else throw new BedrijfException("invalid postcode");
            }
        }
        private string _straatnaam;
        public string Straatnaam
        {
            get { return _straatnaam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _straatnaam = value;
                else throw new BedrijfException("straatnaam niet ok");
            }
        }
        private string _huisnummer;

        public string Huisnummer
        {
            get { return _huisnummer; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && char.IsDigit(value[0])) _huisnummer = value;
                else throw new BedrijfException("huisnummer invalid");
            }
        }
        public override string ToString()
        {
            return $"{Woonplaats},{Postcode},{Straatnaam},{Huisnummer}";
        }

    }
}

