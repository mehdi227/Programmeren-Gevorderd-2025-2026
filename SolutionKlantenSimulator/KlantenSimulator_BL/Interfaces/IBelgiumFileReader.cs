namespace KlantenSimulator_BL.Interfaces
{
    public interface IBelgiumFileReader
    {
        public List<string> ReadMaleNames(string filePath);
        public List<string> ReadFemaleNames(string filePath);
    }
}
