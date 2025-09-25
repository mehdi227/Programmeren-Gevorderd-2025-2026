using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL.Exceptions;

namespace OpdrachtBedrijven_CL.BL
{
    public class Bedrijf {
        public string Naam { get; set; }
        public string Industry { get; set; }
        public string Sector { get; set; }
        public string Hoofdkwartier { get; set; }
        private string _oprichtjaar;

        public Bedrijf(string naam, string industry, string sector, string hoofdkwartier, string oprichtjaar, string extrainfo)
        {
            Naam = naam;
            Industry = industry;
            Sector = sector;
            Hoofdkwartier = hoofdkwartier;
            Oprichtjaar = oprichtjaar;
            Extrainfo = extrainfo;
        }

        public Bedrijf()
        {
        }

        public string Oprichtjaar {
            get { return _oprichtjaar; }
            set
            {
                if (DateTime.Now.Year < Convert.ToInt32(value)) _oprichtjaar = value;
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
        //TODO minstens 1 personeel
        //TODO check geen dubbels
    }
}
