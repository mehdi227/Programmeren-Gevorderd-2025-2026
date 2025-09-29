using BestellingBL;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            DateTime now = DateTime.Now;
            Bestelling b = new Bestelling(now);

            b.VoegProductToe(new Product(10, "stoel", 100), 5);
            b.VoegProductToe(new Product(10, "stoel", 100), 2);

            foreach(var x in b.Producten())
                Console.WriteLine($"product {x.Item1} ");
        }
    }
}
