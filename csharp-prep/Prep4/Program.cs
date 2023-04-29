using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        float sum = 0;
        float avg = 0;
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input != 0)
        {
            Console.WriteLine("Enter number:");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            sum += num;

        }
        avg = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");




    }
}