using System;
using System.IO;

// Abstract base class for goals
abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
        Completed = false;
    }

    public virtual void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description}: {Value} points");
    }

    public abstract void Save(StreamWriter writer);
    public abstract void Load(StreamReader reader);
    
    public virtual int Complete()
    {
        Completed = true;
        return Value;
    }
}

// SimpleGoal class
class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int value)
        : base(name, description, value) { }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("SimpleGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Completed);
    }

    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Completed = bool.Parse(reader.ReadLine());
    }
}

// ChecklistGoal class
class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TimesForCompletion { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, string description, int value, int timesForCompletion, int bonus)
        : base(name, description, value)
    {
        TimesForCompletion = timesForCompletion;
        TimesCompleted = 0;
        Bonus = bonus;
    }

    public override void Display()
    {
        string status = Completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description}: {Value} points, Completed {TimesCompleted}/{TimesForCompletion} times");
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("ChecklistGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Completed);
        writer.WriteLine(TimesCompleted);
        writer.WriteLine(TimesForCompletion);
        writer.WriteLine(Bonus);
    }

    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Completed = bool.Parse(reader.ReadLine());
        TimesCompleted = int.Parse(reader.ReadLine());
        TimesForCompletion = int.Parse(reader.ReadLine());
        Bonus = int.Parse(reader.ReadLine());
    }

    public override int Complete()
    {
        TimesCompleted++;
        if (TimesCompleted >= TimesForCompletion)
        {
            Completed = true;
            return Value + Bonus;
        }
        return Value;
    }
}

// EternalGoal class
class EternalGoal : Goal
{
    public int Streak { get; set; }

    public EternalGoal(string name, string description, int value)
        : base(name, description, value)
    {
        Streak = 0;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("EternalGoal");
        writer.WriteLine(Name);
        writer.WriteLine(Description);
        writer.WriteLine(Value);
        writer.WriteLine(Streak);
    }

    public override void Load(StreamReader reader)
    {
        Name = reader.ReadLine();
        Description = reader.ReadLine();
        Value = int.Parse(reader.ReadLine());
        Streak = int.Parse(reader.ReadLine());
    }

    public override int Complete()
    {
        Streak++;
        return Value;
    }
}
