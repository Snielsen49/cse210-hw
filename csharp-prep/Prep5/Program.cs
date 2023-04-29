using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResult(name,num);

        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int SquareNumber(int num)
        {
            num = num * num;
            return num;
        }
        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }



    }
     
}