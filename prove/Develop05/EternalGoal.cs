public class EternalGoal : Goal
{
 
    public EternalGoal( string goal, string dis, int points, bool comp) :base( goal, dis, points, 2, comp)
    {
       
    }
       public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($"\n");
    }
    public override int CompleteGoal()
    {
        return _points;
    }
    


}