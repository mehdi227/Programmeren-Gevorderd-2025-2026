using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Model
{
    public class GroeneRuimteProject
    {
        public double OppervlakteInVierkanteMeter { get; set; }
        public int Biodiversiteitscore { get; set; }
        public int AantalWandelpaden { get; set; }
        private List<string> _beschikbareFaciliteiten = new();
        public IReadOnlyCollection<string> BeschikbareFaciliteiten => _beschikbareFaciliteiten.AsReadOnly();
        public bool OpnameInWandelroute { get; set; }
        public int Beoordeling { get; set; }
    }
}
