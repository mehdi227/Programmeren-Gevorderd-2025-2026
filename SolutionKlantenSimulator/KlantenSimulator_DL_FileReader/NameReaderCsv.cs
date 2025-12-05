using KlantenSimulator_BL.Interfaces;
using KlantenSimulator_BL.Model;

namespace KlantenSimulator_DL_FileReader
{
    public class NameReaderCsv : INameReaderCsv
    {
        public List<MaleName> ReadFile_MaleNames(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                List<MaleName> maleNames = new();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = new string[2];
                    string name = "";
                    string numberOfOccurancesAsString = "";
                    int numberOfOccurances;
                    //loop to get the name
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!char.IsWhiteSpace(line[i]))
                        {
                            name += line[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    //loop to get the number of occurances
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!char.IsWhiteSpace(line[i]))
                        {
                            if (char.IsDigit(line[i]))
                            {
                                numberOfOccurancesAsString += line[i];
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                    numberOfOccurances = int.Parse(numberOfOccurancesAsString);
                    //make object
                    MaleName maleName = new(name, numberOfOccurances);
                    //add object to list
                    List<MaleName> maleNamesUnordered = new();
                    maleNamesUnordered.Add(maleName);
                    //order list by number of occurances
                    maleNames = maleNamesUnordered.OrderBy(x => x.NumberOfOccurances).ToList();
                    int rank = 0;
                    //loop to give each name their appropriate rank
                    foreach (MaleName x in maleNames)
                    {
                        x.Rank = rank++;
                    }
                }
                return maleNames;
            }
        }
        //public List<FemaleName> ReadFile_FemaleNames()
        //{

        //}
        //public List<LastName> ReadFile_LastNames()
        //{

        //}
    }
}
