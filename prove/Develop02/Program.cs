using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a new random number and a new jornal 
        bool x = true;
        Random rand = new Random();
        Jornal myJornal = new Jornal();

        //loop to repeat the menu until the user enters 5
        while (x == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do?");
            int input = int.Parse(Console.ReadLine());

            //making a new entry and adding to the jornal 
            if (input == 1)
            {

                Entry newEntry = new Entry();
                newEntry._promptNum = rand.Next(0,10);
                Console.WriteLine(newEntry._prompt[newEntry._promptNum]);
                newEntry._text = Console.ReadLine();
                 DateTime currentDate = DateTime.Now;
                newEntry._date = currentDate.ToShortDateString();
                Console.WriteLine("How happy are you today on a scale of 1-10?");
                newEntry._happinessNum = int.Parse(Console.ReadLine());
                myJornal._entrys.Add(newEntry);


            }
            //displaying jornal
            else if (input == 2)
            {
                myJornal.displayJornal();
            }
            //loading a file and adding it to jornal
            else if (input ==3)
            {
                Console.WriteLine("What is the File name:");
                string file = Console.ReadLine();
                LoadListFromFile(myJornal,file);
            }
            //saving the jornal to file 
            else if (input ==4)
            {
                Console.WriteLine("What is the File name:");
                string file = Console.ReadLine();
                SaveListToFile(myJornal._entrys,file);

            }
            //quiting the program 
            else if (input ==5)
            {
                x = false;
            }
        }
    
        
    }
    //saving the list to a given file 
    public static void SaveListToFile(List<Entry> mylist,string filename)
    {
        Console.WriteLine("saving file");
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry ent in mylist)
            {
                outputFile.WriteLine($"{ent._date}~~{ent._promptNum}~~{ent._text}~~{ent._happinessNum}");
            }
        }
    }
    //loading a jornal from a given file 
    public static Jornal LoadListFromFile(Jornal myJornal, string filename)
    {
        Console.WriteLine("Loading File");

        string[] lines = System.IO.File.ReadAllLines(filename);

        //lines will look like this "5/12/2023~~6~~I want to learn more code!~~6"
        foreach (string line in lines)
        {
            string[] splitline = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._date = splitline[0];
            newEntry._promptNum = int.Parse(splitline[1]);
            newEntry._text = splitline[2];
            newEntry._happinessNum = int.Parse(splitline[3]);
            myJornal._entrys.Add(newEntry);

        }
        return myJornal;
    }

    
}