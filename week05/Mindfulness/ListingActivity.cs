using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What are blessings in your life?",
        "Who are your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();
    private int _count;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by listing as many positive items as you can.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;

        do
        {
            prompt = _prompts[_random.Next(_prompts.Count)];
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }
}
