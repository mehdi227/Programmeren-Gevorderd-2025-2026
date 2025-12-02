using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_BL.Model
{
    public class CustomerDataSet
    {
        public int? Id {  get; set; }

        private Dictionary<string, int> _voornaamNaarAantal = new();
        public IReadOnlyDictionary<string,int> VoornaamNaarAantal => _voornaamNaarAantal.AsReadOnly();
    }
}
