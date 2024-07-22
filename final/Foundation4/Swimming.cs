class Swim : Activity
    {
        private int laps;

        public Swim(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (laps * 50) / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Mins) * 60;
        }

        public override double GetPace()
        {
            return Mins / GetDistance();
        }
    }

   