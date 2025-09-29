using System.Net.Http.Headers;
using BestellingBL;

namespace TestBestellingBL
{
    public class ProductUT
    {
        [Theory]
        [InlineData(1)]
        [InlineData(200)]
        public void Test_id_valid(int id)
        {
            Product p = new Product(10,"zetel",125.5);
            p.Id = id;
            Assert.Equal(id, p.Id);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Test_id_invalid(int id) {
            Product p = new Product(10, "zetel", 125.5);
            Assert.Throws<BestellingException>(()=>p.Id=id);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void Test_prijs_valid(double prijs) {
            Product p = new Product(10, "zetel", 125.5);
            p.Prijs = prijs;
            Assert.Equal(prijs,p.Prijs);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(-200)]
        public void Test_prijs_invalid(double prijs) {
            Product p = new Product(10, "zetel", 125.5);
            Assert.Throws<BestellingException>(()=>p.Prijs=prijs);
        }
        [Fact]
        public void Test_naam_valid() {
            Product p = new Product(10, "zetel", 125.5);
            string naam = "zetel";
            Assert.Equal(naam,p.Naam);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" zetel")]
        [InlineData("zetel ")]
        [InlineData(" zetel ")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Test_naam_invalid(string naam) {
            Product p = new Product(10, "zetel", 125.5);
            Assert.Throws<BestellingException>(()=>p.Naam=naam);
        }
        [Fact]
        public void Test_ctor_valid() {
            Product p = new Product(10, "zetel", 125.5);
            Assert.Equal(10, p.Id);
            Assert.Equal("zetel", p.Naam);
            Assert.Equal(125.5, p.Prijs);
        }
        [Theory]
        [InlineData(1,"",125.5)]
        [InlineData(1, " ", 125.5)]
        [InlineData(1, null, 125.5)]
        [InlineData(1, " zetel", 125.5)]
        [InlineData(1, "zetel ", 125.5)]
        [InlineData(1, " zetel ", 125.5)]
        [InlineData(0, "zetel", 125.5)]
        [InlineData(-1,"zetel",125.5)]
        [InlineData(1, "zetel",-1)]
        [InlineData(1, "zetel", -200)]
        public void Test_ctor_invalid(int id, string naam, double prijs) {

        }
    }
}
