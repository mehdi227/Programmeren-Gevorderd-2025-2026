using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestellingBL;
using TestBestellingBL;
namespace BestellingBL {
    public class Bestelling {
        private Dictionary<Product, int> producten = new();
        public Bestelling(DateTime bestelDatum) {
            BestelDatum = bestelDatum;
        }
        public int Id { get; set; }
        private DateTime _besteldatum { get; set; }
        public DateTime BestelDatum {
            get { return _besteldatum; }
            set {
                if (value == default || value >= LeverDatum) throw new BestellingException();
                _besteldatum = value;
            }
        }
        private DateTime? _leverdatum;
        public DateTime? LeverDatum {
            get { return _leverdatum; }
            set {
                if (value != DateTime.MinValue && value <= BestelDatum) throw new BestellingException();
                _leverdatum = value;
            }
        }
        public void VoegProductToe(Product product, int aantal) {
            if (aantal <= 0 || product == null) throw new BestellingException();
            if (producten.ContainsKey(product)) producten[product] += aantal;
            else producten.Add(product, aantal);
        }
        public void VerwijderProduct(Product product, int aantal) {
            if (product == null || aantal <= 0) throw new BestellingException("verwijderproduct");
            if (!producten.ContainsKey(product)) throw new BestellingException("verwijderproduct");
            if (producten[product] > aantal)
                producten[product] -= aantal;
            else if (producten[product] == aantal)
                producten.Remove(product);
            else throw new BestellingException("verwijderproduct");
        }
        public double Prijs() {
            throw new NotImplementedException();
        }
        public IReadOnlyCollection<(Product, int)> Producten() {
            return producten.Select(kvp => (kvp.Key, kvp.Value)).ToList();
        }
    }
}
