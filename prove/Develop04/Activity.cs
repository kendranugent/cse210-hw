abstract class Activity
{
    protected int Length { get; set; }

    public void StartActivity()
    {
        try
        {
            StartMessage();
            Begin();
            EndMessage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private void StartMessage()
    {
        Console.WriteLine($"Starting {GetType().Name.Replace("Activity", "")}...");
        Console.WriteLine(Description());
        Console.WriteLine("How long would you like to participate in this exercise? (Must be at least 6 seconds) ");
        Length = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    private void EndMessage()
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine($"You have completed the {GetType().Name.Replace("Activity", "")} for {Length} seconds.");
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine(); // Wait for the user to press Enter
    }

    protected abstract string Description();
    protected abstract void Begin();
}
