using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_BL.Model
{
    public class LastName
    {
        public LastName(int rank, string name, int numberOfOccurances)
        {
            Rank = rank;
            Name = name;
            NumberOfOccurances = numberOfOccurances;
        }

        public int? Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int NumberOfOccurances { get; set; }
    }
}
