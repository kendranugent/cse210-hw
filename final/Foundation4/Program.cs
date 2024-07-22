using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Run(new DateTime(2022, 11, 3), 30, 3.0), //year, month, day, run length in mins, distance
            new Cycle(new DateTime(2023, 10, 12), 60, 12), //year, month, day, length in mins, speed
            new Swim(new DateTime(2021, 6, 7), 90, 45) //year, month, day, length in mins, number of laps
        };

        foreach (var activity in activities)
        {
            Console.Write(activity.GetSummary());
        }
    }
}