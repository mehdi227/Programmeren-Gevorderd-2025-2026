using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Model
{
    public abstract class Project
    {
        public string Titel { get; set; }
        public DateTime Startdatum { get; set; }
        public enum Status { planning, uitvoering, afgerond }
        public string Beschrijving { get; set; }
        public Locatie Locatie { get; set; }
        private List<ExternePartner> _externePartners = new();
        public IReadOnlyCollection<ExternePartner> ExternePartners => _externePartners.AsReadOnly();
    }
}
