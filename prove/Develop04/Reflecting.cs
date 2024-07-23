using System.Reflection;

class Reflecting : Activity
{
    private static readonly List<string> Questions = new List<string>
    {
        "Think of a time when you stood up for someone else...",
        "Think of a time when you did something really difficult...",
        "Think of a time when you helped someone in need...",
        "Think of a time when you did something truly selfless..."
    };

    private static readonly List<string> Reflection = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string Description()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    List<string> responses = new List<string>();

    protected override void Begin()
    {
        Random random = new Random();
        Console.WriteLine(Questions[random.Next(Questions.Count)]);

        int Time = Length / 6;
        int Remaining = Length;
        while (Remaining > 0)
        {
            Console.WriteLine($"With that in mind...");
            Console.WriteLine(Reflection[random.Next(Reflection.Count)]);
            Thread.Sleep(2000);
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();
            responses.Add(response);
            Animation.ReflectAnim(5);
            Remaining -= Time;
        }

        Console.WriteLine($"You came up with {responses.Count} responses.");
        foreach (var response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}
