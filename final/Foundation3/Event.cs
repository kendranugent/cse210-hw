public abstract class Event
        //base class
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public Address Address { get; private set; }

        protected Event(string title, string description, DateTime date, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Address = address;
        }

        public virtual string GetStandard() //virtual checks for overriding methods
        {
            return $"Title: {Title}, Description: {Description}, Date: {Date}, Address: {Address}\n";
        }

        public abstract string GetFull();

        public string GetShortDes()
        {
            return $"Type: {GetType().Name}, Title: {Title}, Date: {Date.ToShortDateString()}\n";
        }
    }


 public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} {ZipCode}";
        }
    }
