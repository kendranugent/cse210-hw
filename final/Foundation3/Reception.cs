public class Reception : Event
    {
        public string RSVP {get; private set;}

        public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
            : base(title, description, date, address) //used to access members of the base class from within a derived class
        {
            RSVP = rsvpEmail;
        }

        public override string GetFull()
        {
            return $"{GetStandard()}Type: Reception RSVP Email: {RSVP}\n";
        }
    }