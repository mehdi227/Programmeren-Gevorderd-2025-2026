using LinqBedrijvenCL;
using LinqBedrijvenCL.Model;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
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
                        Bedrijf bedrijf = new(naam, industrie, sector, hoofdkwartier, oprichtjaar, extraInfo, new List<Persoon>());
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
                        bedrijf.Werknemers.Add(medewerker);
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
                        bedrijf.Werknemers.Add(medewerker);
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
                var bedrijvenOrderedByAantalWerknemersLimit10 = bedrijven.OrderByDescending(b => b.Value.Werknemers.Count()).Take(10);
                foreach (var item in bedrijvenOrderedByAantalWerknemersLimit10)
                {
                    Console.WriteLine(item.Value.Naam + " " + item.Value.Werknemers.Count());
                }
                //4. Lijst per gemeente het aantal werknemers op. 
                Console.WriteLine("4. Lijst per gemeente het aantal werknemers op. ");
                var werknemersPerGemeente = bedrijven.Values.SelectMany(b => b.Werknemers).GroupBy(w => w.Woonplaats).Select(g => (g.Key, g.Count()));
                foreach (var item in werknemersPerGemeente)
                {
                    Console.WriteLine($"Gemeente: {item.Key}, Aantal Werknemers: {item.Key.Count()}");
                }
                //5. Geef de werknemers die wonen in een opgegeven gemeente.
                Console.WriteLine("5. Geef de werknemers die wonen in een opgegeven gemeente.");
                string input = Console.ReadLine();
                var werknemersInOpgegevenGemeente = bedrijven.Values.SelectMany(b => b.Werknemers).Where(w => w.Woonplaats == input);
                foreach (var item in werknemersInOpgegevenGemeente)
                {
                    Console.WriteLine($"Werknemer: {item.Voornaam}, Woonplaats: {item.Woonplaats}");
                }
                //6. Lijst de verschillende sectoren op en het aantal bedrijven per sector.
                Console.WriteLine("6. Lijst de verschillende sectoren op en het aantal bedrijven per sector.");
                var bedrijvenAantalPerSector = bedrijven.Values.GroupBy(b => b.Sector).Select(b => (b.Key, b.Count()));
                foreach (var item in bedrijvenAantalPerSector)
                {
                    Console.WriteLine($"Sector: {item.Key}, Aantal Bedrijven: {item.Key.Count()}");
                }
                //7. Lijst per industrie de namen van de bedrijven die daartoe behoren.
                Console.WriteLine("7. Lijst per industrie de namen van de bedrijven die daartoe behoren.");
                var bedrijvenPerIndustrie = bedrijven.Values.GroupBy(b => b.Industrie).Select(g => (g.Key, g.Select(b => b.Naam))).ToList();
                foreach (var bedrijf in bedrijvenPerIndustrie)
                {
                    Console.WriteLine($"Industrie: {bedrijf.Key}, ");
                    Console.WriteLine($"Bedrijven:{string.Join(", ", bedrijf.Item2)}");
                }
                //8. Lijst werknemers op die dezelfde naam hebben.
                Console.WriteLine("8. Lijst werknemers op die dezelfde naam hebben.");
                var werkenemersMetZelfdeNaam = bedrijven.Values.SelectMany(b => b.Werknemers).GroupBy(w => w.Voornaam);

                //9. Geef weer hoeveel werknemers er jonger zijn dan 25, tussen 25 en 50 zijn en 50+.
                Console.WriteLine("9. Geef weer hoeveel werknemers er jonger zijn dan 25, tussen 25 en 50 zijn en 50+.");
            }
        }
    }
}
