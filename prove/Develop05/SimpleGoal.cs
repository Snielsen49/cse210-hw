public class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string dis, int points, bool comp) :base ( goal, dis, points, 1, comp)
    {

    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($"\n");
    }
}