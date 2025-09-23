using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtBedrijven_CL.BL
{
    public class Bedrijf {
        private string _naam;
        public string Naam { get; set; }
        private string _industrie;
        public string Industry { get; set; }
        private string _sector;
        public string Sector { get; set; }
        private string _hoofdkwartier;
        public string Hoofdkwartier { get; set; }
        private string _oprichtjaar;
        public string Oprichtjaar { get; set; }
        private string _extrainfo;
        public string Extrainfo { get; set; }
        //TODO minstens 1 personeel
        //TODO check geen dubbels
    }
}
