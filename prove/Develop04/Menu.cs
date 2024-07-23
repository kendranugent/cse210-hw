class Menu
{
    public void Display()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Enter the number corresponding with the activity of your choice:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Reflecting();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid Input");
                    Thread.Sleep(2000);
                    continue;
            }

            if (activity != null)
            {
                activity.StartActivity();
            }
        }
    }
}
