using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities.
        List<Activity> activities = new List<Activity>();

        activities.Add(new Cycling(DateTime.Now, 30, 9.7));
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new Swimming(DateTime.Now, 30, 6));

        // Print out the summaries of the activities.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

            if (activity is Swimming swimming)
            {
                Console.WriteLine("Laps: {0}", swimming.laps);
            }
        }
    }
}