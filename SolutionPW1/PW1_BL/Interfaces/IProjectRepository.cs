using PW1_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GeefProjectenOpPartnerNaam(string naam);
        List<Project> GeefProjectenOpTypeProject(string typeProject);
        List<Project> GeefProjectenOpStatus(Project.Status status);
        List<Project> GeefProjectenOpWijk(Locatie locatie);
        public bool HeeftProject(string naam);
        public void VoegProjectToe(Project project);
    }
}
