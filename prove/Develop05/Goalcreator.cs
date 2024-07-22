using System;
using System.Collections.Generic;
using System.IO;

class GoalCreator
{
    private List<Goal> goals;
    private int userScore;

    public GoalCreator()
    {
        goals = new List<Goal>();
        userScore = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Input the number corresponding with your option: ");
        string choice = Console.ReadLine();

        Console.Write("New goal name: ");
        string name = Console.ReadLine();
        Console.Write("New goal description: ");
        string description = Console.ReadLine();
        Console.Write("New goal value: ");

        if (!int.TryParse(Console.ReadLine(), out int value))
        {
            Console.WriteLine("Invalid Input. Enter a valid number.");
            return;
        }

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, value));
                break;
            case "2":
                Console.Write("Enter times needed for completion: ");
                if (!int.TryParse(Console.ReadLine(), out int timesForCompletion))
                {
                    Console.WriteLine("Invalid input. Enter a valid number.");
                    return;
                }
                Console.Write("Enter bonus value: ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid input. Enter a valid number.");
                    return;
                }
                goals.Add(new ChecklistGoal(name, description, value, timesForCompletion, bonus));
                break;
            case "3":
                goals.Add(new EternalGoal(name, description, value));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public int RecordEvent()
    {
        Console.WriteLine("Chose a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        Console.Write("Options: ");

        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return 0;
        }

        int points = goals[choice - 1].Complete();
        Console.WriteLine($"{goals[choice - 1].Name} recorded. You gained {points} points.");
        userScore += points;
        return points;
    }

    public void ShowGoals()
    {
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }

    public void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(userScore);
            foreach (var goal in goals)
            {
                goal.Save(writer);
            }
        }
        Console.WriteLine("Data saved.");
    }

    public void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                userScore = int.Parse(reader.ReadLine());
                goals.Clear();
                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    Goal goal = null;
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal("", "", 0);
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal("", "", 0, 0, 0);
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal("", "", 0);
                            break;
                    }
                    goal.Load(reader);
                    goals.Add(goal);
                }
            }
            Console.WriteLine("Data loaded.");
        }
        else
        {
            Console.WriteLine("No data file found.");
        }
    }

    public int GetUserScore()
    {
        return userScore;
    }
}
