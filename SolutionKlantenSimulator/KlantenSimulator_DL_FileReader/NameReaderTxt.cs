using KlantenSimulator_BL.Interfaces;
using KlantenSimulator_BL.Model;
using System.Runtime.CompilerServices;

namespace KlantenSimulator_DL_FileReader
{
    public class NameReaderTxt : INameReaderTxt
    {
        public List<MaleName> ReadFile_MaleNames(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<MaleName> maleNames = new();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    int rank = int.Parse(data[0]);
                    string name = data[1];
                    int numberOfOccurances = int.Parse(data[2]);
                    MaleName maleName = new MaleName(rank, name, numberOfOccurances);
                    maleNames.Add(maleName);
                }
                return maleNames;
            }
        }
        public List<FemaleName> ReadFile_FemaleNames(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                List<FemaleName> femaleNames = new();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    int rank = int.Parse(data[0]);
                    string name = data[1];
                    int numberOfOccurances = int.Parse(data[2]);
                    FemaleName femaleName = new FemaleName(rank, name, numberOfOccurances);
                    femaleNames.Add(femaleName);
                }
                return femaleNames;
            }
        }
        public List<LastName> ReadFile_LastNames(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                List<LastName> lastNames = new();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    int rank = int.Parse(data[0]);
                    string name = data[1];
                    int numberOfOccurances = int.Parse(data[2]);
                    LastName lastName = new LastName(rank, name, numberOfOccurances);
                    lastNames.Add(lastName);
                }
                return lastNames;
            }
        }
    }
}
