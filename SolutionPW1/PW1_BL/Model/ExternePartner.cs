using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Model
{
    public class ExternePartner
    {
        public string Naam { get; set; }
        public enum Type { Bedrijf, Organisatie, Burger }
        private List<Project> _projecten = new();
        public IReadOnlyList<Project> Projecten => _projecten.AsReadOnly();
        public string RolOmschrijving { get; set; }
    }
}
