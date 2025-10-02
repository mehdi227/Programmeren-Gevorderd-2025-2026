using BestellingBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBestellingBL {
    public class BestellingUT {
        List<Product> producten = new();
        public BestellingUT() {
            producten.Add(new Product(10, "zetel", 125));
            producten.Add(new Product(11, "tafel", 125));
            producten.Add(new Product(12, "stoel", 125));
        }
        [Fact]
        public void Test_besteldatum_valid() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            Assert.Equal(now, bestelling.BestelDatum);
        }
        [Fact]
        public void Test_besteldatum_invalid() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            Assert.Throws<BestellingException>(() => bestelling.BestelDatum = default);
        }
        [Fact]
        public void Test_besteldatum_invalid_vergelijkmetleverdatum() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.LeverDatum = now.AddHours(1);
            Assert.Throws<BestellingException>(() => bestelling.BestelDatum = now.AddHours(1));
        }
        [Theory]
        [InlineData(null)]
        [InlineData("2025-1-2")]
        public void Test_leverdatum_valid(DateTime leverdatum) {
            DateTime now = new DateTime(2025, 1, 1);
            Bestelling bestelling = new Bestelling(now);
            bestelling.LeverDatum = leverdatum;
            Assert.Equal(leverdatum, bestelling.LeverDatum);
        }
        [Theory]
        [InlineData("2025-1-2")]
        [InlineData("2025-1-1")]
        public void Test_leverdatum_invalid(DateTime leverdatum) {
            DateTime now = new DateTime(2025, 1, 2);
            Bestelling bestelling = new Bestelling(now);
            Assert.Throws<BestellingException>(() => bestelling.LeverDatum = leverdatum);
        }
        [Fact]
        public void Test_voegproductToe_valid() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            //deel1
            bestelling.VoegProductToe(producten[0], 1);
            Assert.Equal((producten[0], 1), bestelling.Producten().First());
            Assert.Single(bestelling.Producten());

            //deel2
            bestelling.VoegProductToe(producten[0], 4);
            Assert.Equal((producten[0], 5), bestelling.Producten().First());
            Assert.Single(bestelling.Producten());

            //deel3
            bestelling.VoegProductToe(producten[2], 4);
            Assert.Equal(2, bestelling.Producten().Count());
            Assert.Contains((producten[0], 5), bestelling.Producten());
            Assert.Contains((producten[2], 4), bestelling.Producten());
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Test_voegproducttoe_invalid_aantal(int aantal) {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.VoegProductToe(producten[0], 5);
            bestelling.VoegProductToe(producten[2], 4);

            Assert.Throws<BestellingException>(() =>
            bestelling.VoegProductToe(producten[0], aantal));
            Assert.Equal(2, bestelling.Producten().Count());
            Assert.Contains((producten[0], 5), bestelling.Producten());
            Assert.Contains((producten[2], 4), bestelling.Producten());
        }
        [Fact]
        public void Test_voegproducttoe_invalid_productnull() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.VoegProductToe(producten[0], 5);
            bestelling.VoegProductToe(producten[2], 4);

            Assert.Throws<BestellingException>(() =>
            bestelling.VoegProductToe(null, 10));
            Assert.Equal(2, bestelling.Producten().Count());
            Assert.Contains((producten[0], 5), bestelling.Producten());
            Assert.Contains((producten[2], 4), bestelling.Producten());
        }
        [Fact]
        public void Test_verwijderproduct_valid() {
            //set up
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.VoegProductToe(producten[0], 5);
            bestelling.VoegProductToe(producten[2], 4);

            //deel1
            bestelling.VerwijderProduct(producten[2], 3);
            Assert.Equal(2, bestelling.Producten().Count());
            Assert.Contains((producten[0], 5), bestelling.Producten());
            Assert.Contains((producten[2], 1), bestelling.Producten());

            //deel2
            bestelling.VerwijderProduct(producten[2], 1);
            Assert.Single(bestelling.Producten());
            Assert.Contains((producten[0], 5), bestelling.Producten());

            //deel 3
            bestelling.VerwijderProduct(producten[0], 5);
            Assert.Empty(bestelling.Producten());
        }
        [Fact]
        public void Test_verwijderproduct_invalid_productbestaatniet() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.VoegProductToe(producten[0], 5);
            bestelling.VoegProductToe(producten[2], 4);

            Assert.Throws<BestellingException>(() =>);
            Assert.Contains();
            Assert.Contains();
        }
        [Fact]
        public void Test_verwijderproduct_invalid_aantaltegroot() {
            DateTime now = DateTime.Now;
            Bestelling bestelling = new Bestelling(now);
            bestelling.VoegProductToe(producten[0], 5);
            bestelling.VoegProductToe(producten[2], 4);

            Assert.Throws<BestellingException>();
            Assert.Contains();
            Assert.Contains();
        }
    }
}
