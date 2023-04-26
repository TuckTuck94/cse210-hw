using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string user_name = UserName();
        int user_number = UserNumber();
        int square_number = SquareNumber(user_number);

        Result(user_name, square_number);
    }
    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("What is your favorite Number?: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"Thank you, {name}!, Did you know the square of your number is {square}?");
    }
}