using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();

        string userInput = Console.ReadLine();
        BreathingActivity breathingActivity1 = new BreathingActivity();
        if (userInput == "1")
        {
            Console.WriteLine(breathingActivity1.ShowBreathingMessage());

       
        }
}
}