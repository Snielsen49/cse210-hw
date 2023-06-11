using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;

        while (run)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1.Breathing Activity");
            Console.WriteLine("2.Reflection Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Quit");
            Console.WriteLine("What would you like to do?");
            int input = int.Parse(Console.ReadLine());

            
            if (input == 1)
            {
                Breathing act = new Breathing();
                act._startBreathing();
            }
            
            else if (input == 2)
            {
                Reflection act = new Reflection();
                act._startReflections();
            }
           
            else if (input ==3)
            {
               Listing act = new Listing();
               act._startListing();
            }
             
            else if (input ==4)
            {
                run = false;
            }
            
        }
    }
}