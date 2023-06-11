public class Reflection : Activity
{
    private string act = "Reflection Activity";
    private string dis = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();
    private List<int> previousInts = new List<int>();
    Random random = new Random();

    public void _startReflections()
    {
        int duration =_startActivity(act,dis);
        
        Console.WriteLine("Consider the following prompt:\n");

        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        int ran = random.Next(0,3);
        Console.WriteLine(prompts[ran]);

        Console.WriteLine("\nWhen you have somthing in mind, press Enter.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder each of the following questions as they pertain to this experance.");
        Console.Write("you may start in: ");
        _fiveSecoundCountDown();
        Console.Clear();

        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        DateTime start = DateTime.Now;
        DateTime End = start.AddSeconds(duration);
        DateTime curent = DateTime.Now;
        int i = 0;
        bool used = true;

        while ( curent < End)
        {
            
            if (i < questions.Count)
            {  
                while(used)
                {
                    used = false;
                    ran = random.Next(0,questions.Count);
                    foreach (int num in previousInts)
                    {
                        if (ran == num)
                        {
                            used = true;
                            break;
                        }
                        
                    }
                }
                previousInts.Add(ran);
                i++;
            }
            else 
            {
                i = 0;
                previousInts.Clear();
                while(used)
                {
                    used = false;
                    ran = random.Next(0,questions.Count);
                    foreach (int num in previousInts)
                    {
                        if (ran == num)
                            used = true;
                            break;
                        
                    }
                }
                previousInts.Add(ran);
                i++;
            }
            Console.Write($"> {questions[ran]}");
            used = true;
            _spinner();
            Console.WriteLine();

            curent = DateTime.Now;
        }
        Console.Clear();
        _endActivity(act);
    }
}      