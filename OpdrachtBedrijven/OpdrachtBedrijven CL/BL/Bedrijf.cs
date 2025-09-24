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
        public string Oprichtjaar {
            get { return _oprichtjaar; }
            set
            {
                if (DateTime.Now.Year < Convert.ToInt32(value)) _oprichtjaar = value;
                else throw new BedrijfException("oprichtjaar mag niet in de toekomst liggen");
            }
        }
        public string Extrainfo { get; set; }
        //TODO minstens 1 personeel
        //TODO check geen dubbels
    }
}
