class Journal 
{
    private List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        string prompt = "Prompt inspiration:\nWhat is something good that happened today?\nHow are you feeling in this exact moment?\nWhat is something that you are looking forward to?\nWhat is something you are frustrated about?\nDid you do something good today?";
        Console.WriteLine($"{prompt}");
        
        string response = Console.ReadLine();

        DateTime CurrentTime = DateTime.Now;
        string date = CurrentTime.ToShortDateString();

        Entry entry = new Entry(date, response);

        entries.Add(entry);
    }

    public void Display() 
    {
        Console.WriteLine("Your Journal Entries");
        Console.WriteLine("....................");
        foreach (Entry entry in entries) 
        {
            entry.Display();
        }
    }
}
