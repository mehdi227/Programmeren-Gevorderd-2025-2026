using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provincies_BL.Model
{
    public class Province
    {
        public Province(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        private Dictionary<int,Municipality> Municipalities { get; set; } = new();
        public void AddMunicipality(Municipality municipality)
        {
            Municipalities.TryAdd(municipality.Id,municipality);
        }
        public bool HasMunicipality(int id)
        {
            return Municipalities.ContainsKey(id);
        }
        public Municipality GetMunicipality(int id)
        {
            return Municipalities[id];
        }
        public IReadOnlyList<Municipality> GetMunicipalities(int id)
        {
            return Municipalities.Values.ToList();
        }
    }
}
