namespace KlantenSimulator_BL.Model
{
    public class Simulator
    {
        public int? Id { get; set; }
        public string Land { get; set; }
        private List<string> _municipalities = new();
        public IReadOnlyCollection<string> Municipalities => _municipalities.AsReadOnly();
        private int _amountOfCustomers;
        public int AmountOfCustomers
        {
            get { return _amountOfCustomers; }
            set { _amountOfCustomers = value; }
        }
        public string Client { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public DateTime Created { get; set; }
    }
}
