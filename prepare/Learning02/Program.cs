using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Sony";
        job1._startYear = 2000;
        job1._endYear = 2001;
        Job job2 = new Job();
        job2._jobTitle = "Bug Tester";
        job2._company = "Samsung";
        job2._startYear = 2002;
        job2._endYear = 2003;

        Resume myResume = new Resume();
        myResume._name = "Soren Nielsen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
       
        myResume.DisplayResume();



    }
}