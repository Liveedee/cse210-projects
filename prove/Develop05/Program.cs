using System.IO;


class Program
{
    
    static void Main(string[] args)
    {

        string fileName = "myGoals.txt";

        Console.WriteLine($"\nMenu Options:\n");
        Menu menu1 = new Menu();

        string userInput = Console.ReadLine();


        

        if (userInput == "1")
        { 
            
            GoalMenu goalmenu1 = new GoalMenu();
            Console.WriteLine($"What type of goal would you like to create:");
            
        
        }

        if (userInput =="2")
        {
            string readFile = File.ReadAllText("myGoals.txt"); 
            Console.WriteLine(readFile);
        }


        string goalInput = Console.ReadLine();
        if (goalInput == "1")
        {
            
            
            Goal goal1 = new Goal();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            outputFile.WriteLine($"Goal Name:{goal1.GetGoalName()} / Goal Description: {goal1.GetDescription()}");
            Console.WriteLine(goal1.GetPoints());
            string userPoints = Console.ReadLine();
            int points = int.Parse(userPoints);
        }

        // if (goalInput == "2");
        // {
        //     ETERNAL GOAL
        // }

        // if (goalInput == "3");
        // {
        //     CHECKLISTGOAL
        // }






}   
    }



        // Goal goal1 = new Goal();

        // Console.WriteLine(goal1.GetName());