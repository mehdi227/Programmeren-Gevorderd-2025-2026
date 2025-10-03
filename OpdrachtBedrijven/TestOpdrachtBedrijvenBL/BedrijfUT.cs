using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpdrachtBedrijvenBL
{
    public class BedrijfUT
    {
        [Theory]
        [InlineData("")]
        [InlineData("KBC")]
        [InlineData(" KBC")]
        [InlineData("KBC ")]
        [InlineData(" KBC ")]
        public void Test_BedrijfNaam_valid(string bedrijfsnaam)
        {

        }
        [Fact]
        public void Test_bedrijfNaam_invalid()
        {

        }
    }
}
