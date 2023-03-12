using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"\nMenu Options:\n");
        Menu menu1 = new Menu();

        string userInput = Console.ReadLine();
        if (userInput == "1")
        { 
            GoalMenu goalmenu1 = new GoalMenu();
            Console.WriteLine($"What type of goal would you like to create:"); 
        
        
        string goalInput = Console.ReadLine();
        if (goalInput == "1")
        {
            Goal goal1 = new Goal();
            Console.WriteLine("okay");
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
}

        // Goal goal1 = new Goal();

        // Console.WriteLine(goal1.GetName());