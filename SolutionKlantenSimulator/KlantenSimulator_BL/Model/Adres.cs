namespace KlantenSimulator_BL.Model
{
    public class Adres
    {
        public Adres(string municipality, string street)
        {
            Municipality = municipality;
            Street = street;
        }

        public int? Id { get; set; }
        public string Municipality { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
    }
}
