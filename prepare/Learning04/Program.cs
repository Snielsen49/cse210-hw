using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newassignment = new MathAssignment("7.3","8-19","Roberto Rodriguez","Fractions");
        Console.WriteLine(newassignment.GetSummary());
        Console.WriteLine(newassignment.GetHomeworkList());

        WritingAssignment newassignment2 = new WritingAssignment("The Causes of World War II by Mary Waters","Mary Waters","European History");
        Console.WriteLine(newassignment2.GetSummary());
        Console.WriteLine(newassignment2.GetWritingInformation());
        


        

    }
}