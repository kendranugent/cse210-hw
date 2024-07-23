class Breathing : Activity
{
    protected override string Description()
    {
        return "This activity will walk you through a breathing exercise to help you calm down or center yourself.";
    }

    protected override void Begin()
    {
        int Time = Length / 6;
        int Remaining = Length;
        while (Remaining > 0)
        {
            Console.WriteLine("Breathe in...");
            Animation.BreathAnim(Time);
            Remaining -= Time;
            Console.WriteLine("Breathe out...");
            Animation.BreathAnim(Time);
            Remaining -= Time;
        }
    }
}
