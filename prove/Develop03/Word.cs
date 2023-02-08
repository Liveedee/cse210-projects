// HIDETHEWORD
using System;
using System.Collections.Generic;
public class Word
{
    
    private string user = "Press enter to continue or type 'quit' to end the program.";
    private string _scriptureString = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";




    private string thankUser = "Thank you for using the Scripture Memorizer!";
    public Word()
    {        
    }

    public void ShowUser()
    {
        Console.WriteLine($"\n{user}");
        string userChoice = Console.ReadLine();
        
        if (userChoice != "quit")
        {
            int i = 0;
            foreach (char word in _scriptureString);
            Console.WriteLine($"{_scriptureString.Replace($"{_scriptureString[i]}","_")}");
            i++;
        
    

        if (userChoice == "quit")
    
        Console.WriteLine($"{thankUser}");
    }
}
}