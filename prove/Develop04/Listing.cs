public class Listing : Activity
{
    private string act = "Listing Activity";
    private string dis = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> prompts = new List<string>();
    Random random = new Random();

    public void _startListing()
    {
        
        int duration = _startActivity(act,dis);
        Console.WriteLine("List as many responses to the following propmt\n");

        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        int ran = random.Next(0,4);
        Console.WriteLine(prompts[ran]);

        Console.Write("\nYou may start in: ");
        _fiveSecoundCountDown();
        Console.Clear();
        Console.WriteLine(prompts[ran]);
        
        
        DateTime start = DateTime.Now;
        DateTime End = start.AddSeconds(duration);
        DateTime curent = DateTime.Now;
        int i=0;
        
        while ( curent < End)
        {
            Console.Write(">");
            Console.ReadLine();
            i++;
            curent = DateTime.Now;
        }
        Console.WriteLine($"You listed {i} items!");
        _endActivity(act);
    }
}