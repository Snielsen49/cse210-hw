using System;


class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your first name? ");
    string fst = Console.ReadLine();

    Console.Write("What is your last name? ");
    string lst = Console.ReadLine();

    Console.WriteLine($"your name is {fst}, {fst} {lst}.");
    }
}