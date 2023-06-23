using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints;
        List<Goal> goals = new List<Goal>();
        // totalPoints += goal.RecordEvent
        // create a menu
        // capture the user input
        // execute action using a swith and case statement
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Please Enter a Number:");

        string option = Console.ReadLine();

        switch(option)
        {
            case "1":
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("What Goal Would You Like?:");
                string goalNumber = Console.ReadLine();

                switch(goalNumber)
                {
                    case "1":
                        // prompt the user for all necessary information (arguments) prompt name, dscription, points
                        // name = ...
                        // desc = ...
                        // points ...
                        SimpleGoal simple = new SimpleGoal(name, description, points); //SimpleGoal(name, desc, points)
                        name = Console.WriteLine("What is your goal?:");
                        description = Console.WriteLine("What is a Description of the Goal?:");
                        points = Console.WriteLine("How Many Points Will It Award?:");
                        goals.Add(simple);
                        break;
                    case "2":
                        EternalGoal eternal = new EternalGoal(name, description, points);
                        name = Console.WriteLine("What is your goal?:");
                        description = Console.WriteLine("What is a Description of the Goal?:");
                        points = Console.WriteLine("How Many Points Will It Award?:");
                        goals.Add(eternal);
                        break;
                    case "3":
                        ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonuspoints, target);
                        name = Console.WriteLine("What is your goal?:");
                        description = Console.WriteLine("What is a Description of the Goal?:");
                        points = Console.WriteLine("How Many Points Will It Award?:");
                        target = Console.WriteLine("How Many Times do you want to complete this goal?");
                        bonuspoints = Console.WriteLine("How many bonus points will it reward?:");
                        goals.Add(checklist);
                        break;
                }
                break;
            case "2":
            break;
            case "3":
            //prompt for filename
            //get filename
            //call save method
            break;
            case "4":
            break;
            // Load Files
            case "5":
            //Record Events
            break;
            case "6":
            break;
        }
    }
}