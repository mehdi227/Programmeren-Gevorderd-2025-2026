namespace KlantenSimulator_DL_FileReader
{
    public class FileReader
    {
        public FileReader()
        {

        }

        public void ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (path.Contains("België"))
                    {
                        string[] data = line.Split(';');
                        int rang = int.Parse(data[0]);
                        string naam = data[1];
                        int aantalKeerVoorgekomen = int.Parse(data[2]);
                    }
                    else if (path.Contains("Denemarken"))
                    {
                        string naam;
                        int aantal;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == ' ')
                            {
                                naam = line.Substring(0, i);
                                break;
                            }
                        }
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsDigit(line[i]))
                            {
                                aantal = int.Parse(line.TrimEnd().Substring(i));
                                break;
                            }
                        }
                    }
                    else if (path.Contains("Polen"))
                    {

                    }
                    else if (path.Contains("Tsjechië"))
                    {

                    }

                }
            }
        }
    }
}
