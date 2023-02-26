using System;

class Program
{
    static void Main(string[] args)
    {
        

        Menu menu1 = new Menu();
        string userInput = Console.ReadLine();
        Activity activity1 = new Activity();
        
        BreathingActivity breathingActivity1 = new BreathingActivity();
        
        if (userInput == "1")
        {
            Console.WriteLine(breathingActivity1.ShowBreathingMessage());
            Console.WriteLine(activity1.GetUserTime());
            int duration = int.Parse(Console.ReadLine());
          
        }
}
}