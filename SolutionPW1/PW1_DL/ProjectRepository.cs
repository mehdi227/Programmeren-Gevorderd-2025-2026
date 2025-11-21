using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PW1_BL;
using PW1_BL.Interfaces;
using PW1_BL.Model;

namespace PW1_DL
{
    public class ProjectRepository : IProjectRepository
    {
        private string connectionstring;

        public ProjectRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public bool HeeftProject(string naam)
        {
            throw new NotImplementedException();
        }
        public void VoegProjectToe(Project project)
        {

            if (project is StadsOntwikkelingsProject)
            {

            } else if (project is GroeneRuimteProject)
            {

            } else
            {

            }
        }
        public List<Project> GeefProjectenOpPartnerNaam(string naam)
        {
            //zoeken op basis van naam partner
        }
        public List<Project> GeefProjectenOpTypeProject(string type)
        {
            //zoeken op basis van type project
        }
        public List<Project> GeefProjectenOpStatus(Project.Status status)
        {
            //zoeken op basis van status
        }
        public List<Project> GeefProjectenOpWijk(Locatie locatie)
        {
            //zoeken op basis van wijk
        }
    }
}
