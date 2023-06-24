using System;
public class Goal
{
    protected string _goal;
    protected string _discription;
    protected int _points;
    protected bool _complete; 
    protected int _goalType;
    protected string _outputstring;
    public  Goal(string goal, string dis,int points, int type, bool comp)
    {
        _goal = goal;
        _discription = dis;
        _complete = comp;
        _goalType = type;
        _points = points;
        
    }
 
    public virtual void SetGoal(string goal, string dis,int points, bool comp, int type,int times, int timesGoal, int bonus)
    {

    }

    public virtual void DisplayGoal()
    {
        if (_complete)
        {
            Console.Write($" [X] {_goal} ({_discription})");
        }
        else 
        {
            Console.Write($" [ ] {_goal} ({_discription})");
        }
    }
    public virtual int CompleteGoal()
    {
        if(_complete)
        {
            return 0;
        }
        else
        {
            _complete = true;
            return _points;
        }
    }
    public virtual string ValuesSplitByCommas()
    {
        _outputstring = string.Join(",",_goalType,_goal,_discription,_complete,_points);
        return _outputstring;
    }


}