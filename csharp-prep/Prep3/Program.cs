using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int MagicNum = int.Parse(Console.ReadLine());

        Random random_number = new Random();
        int MagicNum = random_number.Next(1, 100);
        int guess = -1;

        while (guess != MagicNum)
        {
            Console.Write("What is the number? ");
            guess = int.Parse(Console.ReadLine());

        if (MagicNum > guess)
            {
                Console.WriteLine("Aim Higher");
            }
            
        else if (MagicNum < guess)
            {
                Console.WriteLine("Aim Lower");
            }
        else
            {
                Console.WriteLine("That's correct!");
            }
        }
    }
}