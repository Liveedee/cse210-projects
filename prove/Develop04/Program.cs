using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();
        Console.WriteLine(activity1.DisplayWelcome());
            string userInput = Console.ReadLine();
            if (userInput == "1")
                Console.WriteLine("start breathing activity");
    }
}