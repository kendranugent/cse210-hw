class Cycle : Activity
    {
        private int speed;

        public Cycle(DateTime date, int mins, int speed)
            : base(date, mins)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (GetSpeed() / 60) * 30;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / GetSpeed();
        }
    }

   