using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpdrachtBedrijven_CL;
using OpdrachtBedrijven_CL.BL;
using OpdrachtBedrijven_CL.Exceptions;

namespace TestOpdrachtBedrijvenBL
{
    public class BedrijfUT
    {
        [Theory]
        [InlineData("VLM Airlines")]
        [InlineData(" VLM Airlines")]
        [InlineData("VLM Airlines ")]
        [InlineData(" VLM Airlines ")]
        public void Test_Naam_valid(string naam)
        {
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            bedrijf.Naam = naam;
            Assert.Equal(naam, bedrijf.Naam);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Test_Naam_invalid(string bedrijfsnaam)
        {
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            Assert.Throws<BedrijfException>(() => bedrijf.Naam = bedrijfsnaam);
        }
        [Theory]
        [InlineData("Consumer services")]
        [InlineData(" Consumer services")]
        [InlineData("Consumer services ")]
        [InlineData(" Consumer services ")]
        public void Test_industry_valid(string industry)
        {
            //TODO check if industry is valid
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            bedrijf.Industry = industry;
            Assert.Equal(industry,bedrijf.Industry);
        }
        [Theory]
        public void Test_industry_invalid(string industry)
        {
            //TODO check if industry is invalid
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            Assert.Throws<BedrijfException>(() => bedrijf.Industry = industry);
        }
        [Theory]
        public void Test_sector_valid(string sector)
        {
            //TODO check if sector is valid
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            bedrijf.Sector = sector;
            Assert.Equal(sector,bedrijf.Sector);
        }
        [Theory]
        public void Test_sector_invalid(string sector)
        {
            //TODO check if sector is invalid
        }
        [Theory]
        public void Test_hoofdkwartier_valid(string hoofdkwartier)
        {
            //TODO check if hoofdkwartier is valid
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            bedrijf.Hoofdkwartier = hoofdkwartier;
            Assert.Equal(hoofdkwartier, bedrijf.Sector);
        }
        [Theory]
        public void Test_hoofdkwartier_invalid(string hoofdkwartier)
        {
            //TODO check if hoofdkwartier is invalid
        }
        [Fact]
        public void Test_oprichtjaar_valid()
        {
            //TODO check if oprichtjaar is valid
            Bedrijf bedrijf = new("VLM Airlines", "Consumer services", "Airlines", "Antwerp", 1992, "Airline");
            bedrijf.Oprichtjaar = DateTime.Now.Year;
            Assert.Equal(bedrijf.Oprichtjaar,DateTime.Now.Year);
        }
        [Theory]
        public void Test_oprichtjaar_invalid(string oprichtjaar)
        {
            //TODO check if oprichtjaar is invalid
        }
        
        [Theory]
        public void Test_extraInfo_valid(string extraInfo)
        {
            //TODO check if extraInfo is valid
        }
        [Theory]
        public void Test_extraInfo_invalid(string extraInfo)
        {
            //TODO check if extraInfo is invalid
        }
    }
}
