using KlantenSimulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantenSimulator_DL_FileReader
{
    public class AdresReaderJson
    {
        public (List<MaleName>, List<FemaleName>, List<LastName>) ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                }
            }
        }
    }
}
