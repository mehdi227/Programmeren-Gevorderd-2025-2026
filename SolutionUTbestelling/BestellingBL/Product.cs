using BestellingBL;
using TestBestellingBL;
namespace BestellingBL {
    public class Product {
        public Product(int id, string naam, double prijs) {
            Id = id;
            Naam = naam;
            Prijs = prijs;
        }
        private int _id;
        public int Id {
            get { return _id; }
            set {
                if (value < 1) throw new BestellingException("id invalid");
                _id = value;
            }
        }
        private string _naam;
        public string Naam {
            get { return _naam; }
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Trim() != value) throw new BestellingException("naam invalid");
                _naam = value;
            }
        }
        private double _prijs;
        public double Prijs { 
            get { return _prijs; }
            set {
                if (value < 0) throw new BestellingException("prijs invalid");
                _prijs = value;
            } 
        }
    }
}
