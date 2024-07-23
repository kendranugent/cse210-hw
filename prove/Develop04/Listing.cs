class Listing : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string Description()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    List<string> responses = new List<string>();
    protected override void Begin()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Console.WriteLine("You have 5 seconds to think about the prompt...");
        Thread.Sleep(5000);

        int Time = Length / 6;
        int Remaining = Length;
        while (Remaining > 0)
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            responses.Add(response);
            Remaining -= Time;
        }
        Console.WriteLine($"You came up with {responses.Count} responses.");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}
