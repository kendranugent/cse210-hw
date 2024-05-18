using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> menu = ["New", "Display", "Save", "Load", "Quit"];
        
        Console.WriteLine("This app is a personal Journal. To proceed with using the app, enter a number that corresponds with the action stated in the list below.");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            for (int i = 0; i < menu.Count; i++)        
            {
                Console.WriteLine($"{i+1}. {menu[i]}");
            }
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.NewEntry();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Loading saved journal...");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Saving current journal...");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Quitting Application");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }



        //Look into switch statements
        }
        
        
    }
}