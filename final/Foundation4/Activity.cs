abstract class Activity
    {
        private DateTime date;
        private int mins;

        public Activity(DateTime date, int mins)
        {
            this.date = date;
            this.mins = mins;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Mins
        {
            get {return mins; }
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"({Date.ToString("dd MM yyyy")}) {this.GetType().Name} ({Mins} mins)- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} minutes per mile \n";
        }
    }