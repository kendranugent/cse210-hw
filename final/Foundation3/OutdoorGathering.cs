public class OutdoorGathering : Event
    {
        public string Weather {get; private set;}

        public OutdoorGathering(string title, string description, DateTime date, Address address, string weather)
            : base(title, description, date, address) //used to access members of the base class from within a derived class
        {
            Weather = weather;
        }

        public override string GetFull()
        {
            return $"{GetStandard()}Type: Outdoor Gathering Weather: {Weather}\n";
        }
    }