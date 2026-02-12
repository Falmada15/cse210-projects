using System;

// Exceeding Requirements:
// - Added a new GratitudeActivity as an additional mindfulness option.
// - Implemented an ActivityLog class to track how many times each activity
//   has been completed and the total time spent.
// - Ensured that prompts and reflection questions are not repeated until
//   all have been used in the current session.
// - Added improved animations and structured user interaction.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Gratitude Activity");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                ActivityLog.DisplayLog();
            }
            else if (choice == "5")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
