public class CheckListGoal : Goal
{
    private int _timesCompleted;
    private int _timesGoal;
    private int _bonus;
    private int _returnpoints;
    public CheckListGoal(string goal, string dis,int points,int timescomp, int timesGoal, int bonus, bool comp) :base(goal, dis, points, 3, comp)
    {
        _timesCompleted = timescomp;
        _timesGoal = timesGoal;
        _bonus = bonus;
    }
   
    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($" -- Curently completed {_timesCompleted}/{_timesGoal}\n");
    }
    public override int CompleteGoal()
    {
        _timesCompleted +=1;
        if (_timesCompleted == _timesGoal)
        {
            _complete = true;
            _returnpoints = _points;
            _returnpoints = _returnpoints + _bonus;
            return _returnpoints;
        }
        else if (_timesCompleted < _timesGoal)
        {
            return _points;
        }
        else
        {
            _timesCompleted--;
            return 0;
        }
        
    }
    public override string ValuesSplitByCommas()
    {
        _outputstring = string.Join(",",_goalType,_goal,_discription,_complete,_points,_timesCompleted,_timesGoal,_bonus);
        return _outputstring;
    }


}