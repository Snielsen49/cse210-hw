using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        List<Goal> _listofGoals = new List<Goal>();
        string newgoal;
        string dis;
        int points = 0;
        int newpoints;
        while (run == true)
        {
            Console.Clear();
            Console.WriteLine($"You have {points} points\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Check List Goal");
                Console.WriteLine("What type of Goal would you like to create:");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("What is the name of your Goal:");
                    newgoal = Console.ReadLine();
                    Console.WriteLine("What is a short discription of it:");
                    dis = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this Goal:");
                    newpoints = int.Parse(Console.ReadLine());
                    SimpleGoal newGoal = new SimpleGoal(newgoal,dis,newpoints,false);
                    _listofGoals.Add(newGoal);

                }
                else if (input == 2)
                {
                    Console.WriteLine("What is the name of your Goal:");
                    newgoal = Console.ReadLine();
                    Console.WriteLine("What is a short discription of it:");
                    dis = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this Goal:");
                    newpoints = int.Parse(Console.ReadLine());
                    EternalGoal newGoal = new EternalGoal(newgoal,dis,newpoints,false);
                    _listofGoals.Add(newGoal);

                }
                else if (input == 3)
                {
                    Console.WriteLine("What is the name of your Goal:");
                    newgoal = Console.ReadLine();
                    Console.WriteLine("What is a short discription of it:");
                    dis = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this Goal:");
                    newpoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this Goal need to be acomplished for a bonus:");
                    int timesGoal = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for completing the Goal that many times:");
                    int bonus = int.Parse(Console.ReadLine());
                    CheckListGoal newGoal = new CheckListGoal(newgoal,dis,newpoints, 0,timesGoal,bonus,false);
                    _listofGoals.Add(newGoal);
                }
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("The Goals are:");
                int i = 1;
                foreach (Goal goal in _listofGoals)
                {
                    Console.Write($"{i}.");
                    goal.DisplayGoal();
                    i++;
                }
                Console.WriteLine("Press any key to return to menu");
                Console.ReadLine();

            }
            else if (input == 3)
            {
                Console.Clear();
                Console.WriteLine("What file would you like to save too:");
                string file = Console.ReadLine();
                SaveGoalList(_listofGoals,points,file);
                
            }
            else if (input == 4)
            {
                Console.Clear();
                Console.WriteLine("What file would you like to load from:");
                string file = Console.ReadLine();
                LoadGoalList(ref _listofGoals,ref points,file);
            }
            else if (input == 5)
            {
                int i = 1;
                Console.Clear();
                Console.WriteLine("The Goals are:");
                foreach (Goal goal in _listofGoals)
                {
                    Console.Write($"{i}.");
                    goal.DisplayGoal();
                    i++;
                }
                Console.WriteLine($"\nWhat Goal did you acomplish:");
                input = int.Parse(Console.ReadLine());
                int x = _listofGoals[input - 1].CompleteGoal();
                points = points + x;
                Console.WriteLine($"Congratulations! You earned {x} points!");
                Console.WriteLine($"You now have {points} Points!");
                Console.WriteLine("Press any key to return to menu");
                Console.ReadLine();                
            }
            else if (input == 6)
            {
                run = false;
            }
        }
               
    }
    private static void SaveGoalList(List<Goal> goallist,int points, string filename)
    {
        Console.WriteLine("saving file...");
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach(Goal goal in goallist)
            {
                outputFile.WriteLine(goal.ValuesSplitByCommas());
            }
        }
        Console.WriteLine("File Saved");
        Console.WriteLine("Press any key to return to menu");
        Console.ReadLine();
    }
    private static void LoadGoalList(ref List<Goal> _listofGoals, ref int points, string filename)
    {
        Console.WriteLine("Loading File");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] splitline = line.Split(",");
            int type = int.Parse(splitline[0]);

            if (splitline.Length > 2 && type == 1)
            {
                string goal = splitline[1];
                string dis = splitline[2];
                int newpoints = int.Parse(splitline[4]);
                bool comp = bool.Parse(splitline[3]);

                SimpleGoal newgoal = new SimpleGoal(goal,dis,newpoints,comp);
                _listofGoals.Add(newgoal);

            }
            else if(splitline.Length > 2 && type == 2)
            {
                string goal = splitline[1];
                string dis = splitline[2];
                int newpoints = int.Parse(splitline[4]);
                bool comp = bool.Parse(splitline[3]);

                EternalGoal newgoal = new EternalGoal(goal,dis,newpoints,comp);
                _listofGoals.Add(newgoal);
            }
            else if(splitline.Length > 2 && type == 3)
            {
                string goal = splitline[1];
                string dis = splitline[2];
                int newpoints = int.Parse(splitline[4]);
                bool comp = bool.Parse(splitline[3]);
                int timescomp = int.Parse(splitline[5]);
                int timesgoal = int.Parse(splitline[6]);
                int bonus = int.Parse(splitline[7]);

                CheckListGoal newgoal = new CheckListGoal(goal,dis,newpoints,timescomp,timesgoal,bonus,comp);
                _listofGoals.Add(newgoal);
            }
            else
            {
                points = type;
            }
        }
        Console.WriteLine("File Loaded");
        Console.WriteLine("Press any key to return to menu");
        Console.ReadLine();
    }
}