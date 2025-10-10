using LinqBedrijvenCL;
using LinqBedrijvenCL.Model;
using System.Globalization;
namespace LinqBedrijven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Bedrijf> bedrijven = new Dictionary<string, Bedrijf>();

            //Streamreader om data in te lezen
            using (StreamReader sr = new StreamReader("C:\\Users\\mehdi\\Downloads\\bedrijvenbelgie_LINQ_v4.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');

                    if (!bedrijven.ContainsKey(data[0]))
                    {
                        //Bedrijf
                        string naam = data[0];
                        string industrie = data[1];
                        string sector = data[2];
                        string hoofdkwartier = data[3];
                        int oprichtjaar = int.Parse(data[4]);
                        string extraInfo = data[5];
                        Bedrijf bedrijf = new(naam, industrie, sector, hoofdkwartier, oprichtjaar,extraInfo, new List<Persoon>());
                        //Medewerker
                        int id = int.Parse(data[6]);
                        string voornaam = data[7];
                        string achternaam = data[8];
                        DateTime geboortedatum = DateTime.ParseExact(data[9], "d/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        string woonplaats = data[10];
                        int postcode = int.Parse(data[11]);
                        string straatnaam = data[12];
                        string huisnummer = data[13];
                        string email = data[14];
                        Persoon medewerker = new(id, voornaam, achternaam, geboortedatum, woonplaats, postcode, straatnaam, huisnummer, email);
                        //Medewerker toevoegen aan bedrijf
                        bedrijf.Medewerkers.Add(medewerker);
                        //Toevoegen aan dictionary
                        bedrijven.Add(bedrijf.Naam, bedrijf);
                    }
                    else
                    {
                        Bedrijf bedrijf = bedrijven[data[0]];

                        //Medewerker
                        int id = int.Parse(data[6]);
                        string voornaam = data[7];
                        string achternaam = data[8];
                        DateTime geboortedatum = DateTime.ParseExact(data[9], "d/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        string woonplaats = data[10];
                        int postcode = int.Parse(data[11]);
                        string straatnaam = data[12];
                        string huisnummer = data[13];
                        string email = data[14];
                        Persoon medewerker = new(id, voornaam, achternaam, geboortedatum, woonplaats, postcode, straatnaam, huisnummer, email);
                        //Medewerker toevoegen aan bedrijf
                        bedrijf.Medewerkers.Add(medewerker);
                    }
                }
                //1. Lijst alle bedrijven op en sorteer ook op naam.
                Console.WriteLine("1. Lijst alle bedrijven op en sorteer ook op naam.");
                var bedrijvenOrderedByNaam = bedrijven.OrderBy(b => b.Value.Naam).ToList();
                foreach (var item in bedrijvenOrderedByNaam)
                {
                    Console.WriteLine(item.Value.Naam);
                }
                //2. Lijst de bedrijven op samen met het jaar van oprichting en plaats de oudste bedrijven eerst.
                Console.WriteLine("2. Lijst de bedrijven op samen met het jaar van oprichting en plaats de oudste bedrijven eerst.");
                var bedrijvenOrderedByOprichtjaar = bedrijven.OrderBy(b => b.Value.Oprichtjaar).ToList();
                foreach (var item in bedrijvenOrderedByOprichtjaar)
                {
                    Console.WriteLine(item.Value.Naam + " " + item.Value.Oprichtjaar);
                }
                //3. Lijst de 10 grootste (volgens aantal werknemers) bedrijven op en het aantal werknemers.
                Console.WriteLine("3. Lijst de 10 grootste (volgens aantal werknemers) bedrijven op en het aantal werknemers.");
                var bedrijvenOrderedByAantalWerknemersLimit10 = bedrijven.OrderByDescending(b => b.Value.Medewerkers.Count()).Take(10);
                foreach (var item in bedrijvenOrderedByAantalWerknemersLimit10)
                {
                    Console.WriteLine(item.Value.Naam + " " + item.Value.Medewerkers.Count());
                }

            }
        }
    }
}
