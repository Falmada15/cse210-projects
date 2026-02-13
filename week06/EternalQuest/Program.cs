using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

/*
Creativity: Added a level-up system and bonus celebrations for completing goals.
Each goal type supports full save/load including description, points, and progress.
*/
