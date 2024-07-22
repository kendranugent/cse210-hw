public class Lecture : Event
    {
        public string Speaker {get; private set;}
        public int Capacity {get; private set;}

        public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity)
            : base(title, description, date, address) //used to access members of the base class from within a derived class
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFull()
        {
            return $"{GetStandard()}Type: Lecture Speaker and Capacity: {Speaker} {Capacity}\n";
        }
    }