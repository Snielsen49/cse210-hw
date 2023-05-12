public class Entry
{
    public string _text;
    public string _date;
    public int _promptNum;
    public int _happinessNum;
    public List<string> _prompt = new List<string>()
    {
        "What are some things you are grateful for today, and why?",
        "What was the most challenging experience you faced today, and what did you learn from it?",
        "Write about a goal you have for yourself and what steps you are taking to achieve it.",
        "What are some things that make you happy, and how can you incorporate them more into your life?",
        "What are some obstacles you have overcome in the past, and how did you do it?",
        "Write about a person who has influenced your life and why they are important to you.",
        "What are some things you want to learn or explore more deeply, and why?",
        "Describe a place that makes you feel calm and peaceful, and what about it has that effect on you?",
        "Write about a decision you made recently and how it has impacted your life.",
        "What are some things you are looking forward to in the near future, and why?"
    };

    public void _displayEntry()
    {
        Console.WriteLine($"Date:{_date}  Prompt:{_prompt[_promptNum]}");
        Console.WriteLine(_text);
        Console.WriteLine($"Your overall happyness level from 1-10 was {_happinessNum}.");

    }
}