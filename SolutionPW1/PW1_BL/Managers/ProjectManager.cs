using PW1_BL.Interfaces;
using PW1_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW1_BL.Managers
{
    public class ProjectManager
    {
        private IProjectRepository _repo;

        public ProjectManager(IProjectRepository repo)
        {
            _repo = repo;
        }
        public void VoegProjectToe(Project project)
        {
            if (!_repo.HeeftProject(project.Titel)) _repo.VoegProjectToe(project);
        }
        public List<Project> GeefProjectenOpPartnerNaam(string naam)
        {
            _repo.GeefProjectenOpPartnerNaam(naam);
        }
        public List<Project> GeefProjectenOpTypeProject(string typeProject)
        {
            _repo.GeefProjectenOpTypeProject(typeProject);
        }
        public List<Project> GeefProjectenOpStatus(Project.Status status)
        {
            _repo.GeefProjectenOpStatus(status);
        }
        public List<Project> GeefProjectenOpWijk(Locatie locatie)
        {
            _repo.GeefProjectenOpWijk(locatie.Wijk);
        }
    }
}

