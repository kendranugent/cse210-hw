using System;

class Program
{
    static void Main(string[] args)
    {
        GoalCreator goalCreator = new GoalCreator();
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            running = menu.ChooseAndRun(goalCreator);
        }
    }
}
