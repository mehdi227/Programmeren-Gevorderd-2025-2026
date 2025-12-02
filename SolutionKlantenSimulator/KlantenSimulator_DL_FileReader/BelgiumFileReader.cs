using KlantenSimulator_BL.Interfaces;
using System.IO;

namespace KlantenSimulator_DL_FileReader
{
    internal class BelgiumFileReader : IBelgiumFileReader
    {
        public List<string> ReadMaleNames(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    string naam = data[1];
                    int aantalKeerVoorgekomen = int.Parse(data[2]);
                }
            }
                    
        }
        public List<string> ReadFemaleNames(string filePath)
        {

        }
    }
}
