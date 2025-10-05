using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL.Exceptions;

namespace OpdrachtBedrijven_CL.BL
{
    public class Bedrijf {
        public Bedrijf(string naam, string industry, string sector, string hoofdkwartier, string oprichtjaar, string extrainfo)
        {
            Naam = naam;
            Industry = industry;
            Sector = sector;
            Hoofdkwartier = hoofdkwartier;
            Oprichtjaar = oprichtjaar;
            Extrainfo = extrainfo;
        }
        private string _naam;
        public string Naam {
            get { return _naam; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _naam = value;
                else throw new BedrijfException("naam invalid");
            }
        }
        private string _industry;
        public string Industry {
            get { return _industry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _industry = value;
                else throw new BedrijfException("industry invalid");
            }
        }
        private string _sector;
        public string Sector {
            get { return _sector; }
            set{
                if (!string.IsNullOrWhiteSpace(value)) _sector = value;
                else throw new BedrijfException("sector invalid");
            }
        }
        private string _hoofdkwartier;
        public string Hoofdkwartier {
            get { return _hoofdkwartier; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _hoofdkwartier = value;
                else throw new BedrijfException("hoofdkwartier invalid");
            }
        }
        private string _oprichtjaar;
        public string Oprichtjaar {
            get { return _oprichtjaar; }
            set
            {
                if (DateTime.Now.Year > Convert.ToInt32(value)) _oprichtjaar = value;
                else throw new BedrijfException("oprichtjaar mag niet in de toekomst liggen");
            }
        }
        public string Extrainfo { get; set; }
        private List<Personeel> _personeelsLeden;
        public List<Personeel> PersoneelsLeden {
            get { return _personeelsLeden; }
            set
            {
                if (value.Count < 1) throw new BedrijfException("moet minstens 1 personeelsLid hebben");
                if (value.Count() != value.Distinct().Count()) throw new BedrijfException("mag geen dubbele personeelsleden bevatten");
            }
        }
    }
}
