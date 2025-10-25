using OpdrachtBedrijven_CL.Domein.BL;
using OpdrachtBedrijven_CL.Domein.DL;
using OpdrachtBedrijven_CL.Domein.Exceptions;

namespace ConsoleAppTestDomein {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Adres adres = new Adres("Gent", "Bijloke", "45", 9000);
            try {
                Console.WriteLine(adres);
            } catch (BedrijfException ex) {
                Console.WriteLine(ex.Message);
            }

            BestandLezer bl = new BestandLezer("D:\\HoGent\\Jaar1\\Sem2\\PG1\\Programmeren-Gevorderd-2025-2026\\data\\OpdrachtBedrijven\\TestData.txt", "D:\\HoGent\\Jaar1\\Sem2\\PG1\\Programmeren-Gevorderd-2025-2026\\data\\OpdrachtBedrijven\\ErrorLog.txt");
        }
    }
}
