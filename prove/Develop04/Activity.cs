public class Activity
{
    private int duration;
    private List <string> animetionchars = new List<string>();

    public void _setDuration (int dur)
    {
        duration = dur;
        
    }

    public int _getDuration()
    {
        return duration;
    }

    public int _startActivity(string activity, string discription)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activity} Activity! \n");
        Console.WriteLine($"This activity will help you {discription}\n");
        Console.WriteLine("How long, in seconds, would you like for your sesion:");
        duration = int.Parse(Console.ReadLine()); 
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        _spinner();

        Console.Clear();
        return duration;
    
    }

    public void _endActivity(string activity)
    {

        Console.WriteLine("Well done!");

        _spinner();
        
        Console.WriteLine($"\nYou have completed {duration} secounds of the {activity}!");

        _spinner();
    }
    public void _fiveSecoundCountDown()
    {
        for (int i = 5; i > 0; )
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i--;
            }
    }
    public void _spinner()
    {
        animetionchars.Add("|");
        animetionchars.Add("/");
        animetionchars.Add("-");
        animetionchars.Add("\\");

        DateTime start = DateTime.Now;
        DateTime End = start.AddSeconds(5);
        DateTime curent = DateTime.Now;

        while (curent < End)
        {

            foreach(string chars in animetionchars)
            {
                Console.Write(chars);
                Thread.Sleep(200);
                Console.Write("\b \b");

            }
            curent = DateTime.Now;
        }
    }


}