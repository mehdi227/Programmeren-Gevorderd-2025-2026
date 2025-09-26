using OpdrachtBedrijven_CL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtBedrijven_CL.DL
{
    public class BestandBeheerder
    {
        Dictionary<Bedrijf, List<Personeel>> BedrijfNaarPersoneel { get; set; }
        Dictionary<string, Personeel> WoonplaatsNaarPersoneel { get; set; }
        public void GeefPersoneelOverzicht(Bedrijf bedrijf) {
            //TODO zoek in de dictionary naar het juiste bedrijf met de gegeven parameter
        }
        public void GeefPersoneel(string woonplaats) {
            //TODO zoek de juiste werkenemer op basis van de woonplaats
        }
    }
}
