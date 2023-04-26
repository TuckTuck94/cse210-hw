using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>();
        Console.WriteLine("Enter a Value (0 will Terminate the Program)");
        int userinput = -1;
        while (userinput != 0)
        {
            
            Console.Write("Enter a Value: ");

            string user_value = Console.ReadLine();
            userinput = int.Parse(user_value);

            if (userinput != 0)
            {
                values.Add(userinput);
            }
        }

        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }

        Console.WriteLine($"Sum: {sum}");

        float ave = ((float)sum) / values.Count;
        Console.WriteLine($"Average: {ave}");

        int maximum = values[0];

        foreach (int value in values)
        {
            if (value > maximum)
            {
                maximum = value;
            }
        }
        Console.WriteLine($"Max: {maximum}");
    }
}