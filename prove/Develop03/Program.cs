using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture();
        scripture._storeScripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");
        bool run = true;
        while (run)
        {
            Console.Clear();
            reference._displayReference();
            scripture._displayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();
            if (input == "quit" || scripture._allHidden())
            {
                run =false;
            }
            scripture._hideRandomeWords();

        }
    }
}