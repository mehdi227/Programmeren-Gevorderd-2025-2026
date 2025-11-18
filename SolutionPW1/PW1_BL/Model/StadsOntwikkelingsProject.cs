using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Model
{
    public class StadsOntwikkelingsProject : Project
    {
        private List<Firma> _betrokkenFirmas = new();
        public IReadOnlyCollection<Firma> BetrokkenFirmas => BetrokkenFirmas;
        public enum VergunningStatus { aangevraagd, goedgekeurd, geweigerd }
        public bool ArchitecturaleWaarde { get; set; }
        public enum OpenbareToegankelijkheid { volledig, gedeeltelijk, gesloten }
        public bool Bezienswaardigheid { get; set; }
        public bool UitlegbordOfInfoWandeling { get; set; }
    }
}
