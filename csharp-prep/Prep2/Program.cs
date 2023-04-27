using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int pct = int.Parse(answer);

        string grade = "";

        if (pct >= 90)
        {
            grade = "A";
        }
        else if (pct >= 80)
        {
            grade = "B";
        }
        else if (pct >= 70)
        {
            grade = "C";
        }
        else if (pct >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");
        
        if (pct >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}