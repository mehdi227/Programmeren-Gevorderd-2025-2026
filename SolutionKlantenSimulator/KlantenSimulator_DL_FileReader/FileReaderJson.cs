using KlantenSimulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlantenSimulator_BL.Interfaces;

namespace KlantenSimulator_DL_FileReader
{
    public class FileReaderJson : IFileReaderJson
    {
        public (List<MaleName>, List<FemaleName>, List<LastName>) ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                List<MaleName> maleNames = new();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("first_name_male") || !line.Contains("first_name_female") || !line.Contains("last_name"))
                    {
                        string name = line.Remove(1, line.Length - 2);
                        MaleName maleName = new(name, 1);
                        if (maleNames.Contains(maleName))
                        {
                            MaleName x = maleNames.Where(x => x.Name == maleName.Name);
                            foreach (MaleName y in x)
                            {
                                y.NumberOfOccurances++;
                            }
                        }
                    }
                }
            }
        }
    }
}
