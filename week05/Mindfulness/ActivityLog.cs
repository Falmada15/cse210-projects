using System;
using System.Collections.Generic;

public static class ActivityLog
{
    private static Dictionary<string, int> _activityCount = new Dictionary<string, int>();
    private static Dictionary<string, int> _activityTime = new Dictionary<string, int>();

    public static void Record(string name, int duration)
    {
        if (!_activityCount.ContainsKey(name))
        {
            _activityCount[name] = 0;
            _activityTime[name] = 0;
        }

        _activityCount[name]++;
        _activityTime[name] += duration;
    }

    public static void DisplayLog()
    {
        Console.WriteLine();
        Console.WriteLine("Activity Log Summary:");
        Console.WriteLine("----------------------");

        if (_activityCount.Count == 0)
        {
            Console.WriteLine("No activities completed yet.");
            return;
        }

        foreach (var activity in _activityCount.Keys)
        {
            Console.WriteLine($"{activity}: {_activityCount[activity]} times | Total Time: {_activityTime[activity]} seconds");
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }
}
