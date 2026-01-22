using System;

/*
EXCEED REQUIREMENTS:
In addition to the required data, this program also stores the user's mood
for each journal entry. This helps users reflect not only on events, but also
on how they were feeling that day.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Console.Write("How are you feeling today? ");
                    string mood = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;

                case "5":
                    running = false;
                    break;
            }
        }
    }
}
