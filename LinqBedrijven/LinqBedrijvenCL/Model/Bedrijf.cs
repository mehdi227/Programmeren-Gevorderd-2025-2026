using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBedrijvenCL.Model
{
    public class Bedrijf
    {
        public Bedrijf(string naam, string industrie, string sector, string hoofdkwartier,int oprichtjaar, string extrainfo, List<Persoon> medewerkers)
        {
            Naam = naam;
            Industrie = industrie;
            Sector = sector;
            Hoofdkwartier = hoofdkwartier;
            Oprichtjaar = oprichtjaar;
            Extrainfo = extrainfo;
            Werknemers = medewerkers;
        }

        public string Naam { get; set; }
        public string Industrie { get; set; }
        public string Sector { get; set; }
        public string Hoofdkwartier { get; set; }
        public int Oprichtjaar { get; set; }
        public string Extrainfo { get; set; }
        public List<Persoon> Werknemers { get; set; }
    }
}
