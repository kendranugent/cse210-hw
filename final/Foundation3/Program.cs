class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("102 University Drive", "Rexburg", "ID", "83440");
            Address address2 = new Address("975 Balboa Avenue", "Laguna Beach", "CA", "92651");
            Address address3 = new Address("753 State street", "Park City", "MT", "35795");

                                        //Title, description, year, month, day, hour, minute, second, address, Speaker, capacity
            Event lecture = new Lecture("Surviving Finals", "Tools for Succeeding the hardest week of every semester.", new DateTime(2024, 7, 18, 8, 15, 0), address1, "Brother Huntsman", 240);
                                            //Title, description, year, month, day, hour, minute, second, address, email 
            Event reception = new Reception("Mom Hug", "An event to hug The best person in the world.", new DateTime(2024, 8, 3, 9, 0, 0), address2, "KerryNugentBestMom@gmail.com");
                                                        // Title, description, year, month, day, hour, minute, second, address, weather
            Event outdoorGathering = new OutdoorGathering("Family Reunion", "Family reunion for anyone that has a last name starting with the letter N.", new DateTime(2029, 7, 9, 13, 30, 0), address3, "Sunny and Clear Sky");

            Event[] events = { lecture, reception, outdoorGathering };

            foreach (var evDets in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(evDets.GetStandard());
                Console.WriteLine("Full Details:");
                Console.WriteLine(evDets.GetFull());
                Console.WriteLine("Short Description:");
                Console.WriteLine(evDets.GetShortDes());
                Console.WriteLine(".............");
            }
        }
    }
