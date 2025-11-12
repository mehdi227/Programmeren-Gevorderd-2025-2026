using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provincies_BL.Model
{
    public class Municipality
    {
        public Municipality(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        private SortedSet<string> StreetNames;
        public void AddStreetName(string streetName)
        {
            StreetNames.Add(streetName);
        }
        public IReadOnlyList<string> GetStreetNames()
        {
            return StreetNames.ToList();
        }
    }
}
