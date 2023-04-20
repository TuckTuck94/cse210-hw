using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your current grade?: ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter_grade = "";

        if (percentage >= 90)
        {
            letter_grade = "A";
        }
        else if (percentage >= 80)
        {
            letter_grade = "B";
        }
        else if (percentage >= 70)
        {
            letter_grade = "C";
        }
        else if (percentage >= 60)
        {
            letter_grade = "D";
        }
        else{
            letter_grade = "F";
        }

        Console.WriteLine($"Your Current Grade: {answer}");

        if (percentage >= 70)
        { 
            Console.WriteLine("Congratulations! You Passed the Class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed. Keep trying!");
        }
    }
}