using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _entries = new List<string>();

    public GratitudeActivity()
    {
        _name = "Gratitude";
        _description = "This activity helps you focus on gratitude by listing things you are thankful for.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Begin listing things you are grateful for:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _entries.Add(input);
            }
        }

        if (_entries.Count > 0)
        {
            Random random = new Random();
            string randomEntry = _entries[random.Next(_entries.Count)];

            Console.WriteLine();
            Console.WriteLine("Remember this blessing:");
            ShowGrowingDots();
            Console.WriteLine(randomEntry);
        }

        DisplayEndingMessage();
    }

    private void ShowGrowingDots()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}
