
class Run : Activity
    {
        private double distance;

        public Run(DateTime date, int mins, double distance)
            : base(date, mins)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (distance / Mins) * 60;
        }

        public override double GetPace()
        {
            return Mins / distance;
        }
    }