public class Breathing : Activity
{
    private string act = "Breathing Activity";
    private string dis = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void _startBreathing()
    {
        
        int duration = _startActivity(act,dis);
        DateTime start = DateTime.Now;
        DateTime End = start.AddSeconds(duration);
        DateTime curent = DateTime.Now;
        
        while ( curent < End)
        {
            Console.Write("Breathe in...");
            _fiveSecoundCountDown();

            Console.WriteLine();
            Console.Write("Breathe out...");
            _fiveSecoundCountDown();
            curent = DateTime.Now;
            Console.WriteLine("\n");
        }
        _endActivity(act);

    }
}   