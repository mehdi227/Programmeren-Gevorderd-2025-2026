using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PW1_BL;
using PW1_BL.Exceptions;
using PW1_BL.Interfaces;
using PW1_BL.Model;

namespace PW1_DL
{
    public class ProjectRepository : IProjectRepository
    {
        private string connectionstring = "";

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

            } else if (project is InnovatiefWonenProject)
            {

            }
        }
        public List<Project> GeefProjectenOpPartnerNaam(string naam)
        {
            //zoeken op basis van naam partner
            List<Project> data = new();
            string SQL;
            if (string.IsNullOrWhiteSpace(naam))
            {
                throw new ProjectException("naam van partner is NULL of whitespace");
            }
            else
            {
                SQL = $"SELECT * FROM projecten p JOIN projecten_externePartners e ON p.id = e.project_ID JOIN externePartners ex ON e.ExternePartner_ID = ex.id WHERE ex.naam LIKE %@naam%";
                using (SqlConnection conn = new SqlConnection(connectionstring))
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = SQL;
                    cmd.Parameters.AddWithValue("@naam", naam);
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if ()
                        {

                        }
                        data.Add(new proje);
                    }
                }
            }
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
