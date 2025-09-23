using OpdrachtBedrijven_CL.BL;
using OpdrachtBedrijven_CL.Exceptions;
namespace ConsoleAppTestDomein {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello, World!");
            //Adres adres = new Adres("Gent","Bijloke","45",9500);
            //try {
            //    Console.WriteLine(adres);
            //} catch(BedrijfException ex) {
            //    Console.WriteLine(ex.Message);
            //}
            Console.WriteLine("Hello, World!");
            Adres adres1 = null;
            try {
                adres1 = new Adres("Gent", "Bijloke", "45", 9000);
            } catch (BedrijfException ex) {
                Console.WriteLine(ex.Message);
                foreach (var e in ex.Errors) Console.WriteLine(e);
            }
            Adres adres2 = null;
            try {
                adres2 = new Adres("Gent", "Bijloke", "45", 90000);
            } catch (BedrijfException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(adres1);
            Console.WriteLine(adres2);
        }
    }
}
