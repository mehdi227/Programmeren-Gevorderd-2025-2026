using OpdrachtBedrijven_CL.BL;
using OpdrachtBedrijven_CL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpdrachtBedrijvenBL
{
    public class PersoneelUT
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5000)]
        public void Test_id_valid(int id)
        {
            //TODO check if id is valid
            Personeel personeel = new Personeel(1,"mehdi","zirar","zirarmehdi84@gmail.com",DateTime.Parse("2003-31-01"),new Adres("Gent","Antwerpsesteenweg","1/0304",9000));
            personeel.Id = id;
            Assert.Equal(id, personeel.Id);
        }
        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-5000)]
        public void Test_id_invalid(int id)
        {
            //TODO check if id is invalid
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
            Assert.Throws<BedrijfException>(() => personeel.Id = id);
        }
        [Theory]
        [InlineData("mehdi")]
        [InlineData(" mehdi")]
        [InlineData("mehdi ")]
        [InlineData(" mehdi ")]
        public void Test_voornaam_valid(string voornaam)
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
            personeel.Voornaam = voornaam;
            Assert.Equal(personeel.Voornaam,voornaam);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Test_voornaam_invalid(string voornaam)
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
            Assert.Throws<BedrijfException>(() => personeel.Voornaam = voornaam);
        }
        [Fact]
        public void Test_achternaam_valid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
        [Fact]
        public void Test_achternaam_invalid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-01-31"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
        [Fact]
        public void Test_geboortedatum_valid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
        [Fact]
        public void Test_geboortedatum_invalid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
        [Fact]
        public void Test_email_valid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
        [Fact]
        public void Test_email_invalid()
        {
            Personeel personeel = new Personeel(1, "mehdi", "zirar", "zirarmehdi84@gmail.com", DateTime.Parse("2003-31-01"), new Adres("Gent", "Antwerpsesteenweg", "1/0304", 9000));
        }
    }
}
