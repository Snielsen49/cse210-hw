using System;

class Program
{
    static void Main(string[] args)
    {

        bool win = false;
        int guess = 0;
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        while (win == false)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (guess == num)
            {
                win = true;
            }
            if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
            


            
        }

    }
}