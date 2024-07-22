using System;

class Menu
{
    private string[] menuItems =
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };

    public bool ChooseAndRun(GoalCreator goalCreator)
    {
        Console.WriteLine($"\nYou  have {goalCreator.GetUserScore()} points \nMenu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }

        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > menuItems.Length)
        {
            Console.WriteLine("Invalid Input. Try again.");
            return true;
        }

        Console.WriteLine();

        switch (choice)
        {
            case 1:
                goalCreator.CreateGoal();
                break;
            case 2:
                goalCreator.ShowGoals();
                break;
            case 3:
                goalCreator.SaveData();
                break;
            case 4:
                goalCreator.LoadData();
                break;
            case 5:
                goalCreator.RecordEvent();
                break;
            case 6:
                Console.WriteLine("Quit");
                return false;
        }
        return true;
    }
}
