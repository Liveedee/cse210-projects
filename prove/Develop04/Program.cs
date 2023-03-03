using System;

class Program
{
    static void Main(string[] args)
    {
        

        Menu menu1 = new Menu();
        string userInput = Console.ReadLine();
        Activity activity1 = new Activity();
        
        BreathingActivity breathingActivity1 = new BreathingActivity();
        Reflecting reflecting1 = new Reflecting();
        ListingActivity listing1 = new ListingActivity();
        if (userInput == "1")
        {   
            Console.WriteLine(breathingActivity1.ShowBreathingMessage());
            Console.WriteLine(activity1.GetUserTime());
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine(activity1.DisplayStart());
            Console.Write(activity1.DoAnimation());
        }
        if (userInput == "2")
        {
            // Console.WriteLine(reflecting1.ShowReflectingMessage());
            Console.WriteLine(activity1.GetUserTime());
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine(activity1.DisplayStart()); 
        }
        if (userInput == "3")
        {
            Console.WriteLine(listing1.ShowListingMessage());
            Console.WriteLine(activity1.GetUserTime());
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine(activity1.DisplayStart()); 
        }
        if (userInput == "4")
        {
            Console.WriteLine($"Thank you for using the mindfulness program!");
        }
}
}