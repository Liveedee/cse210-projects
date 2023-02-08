// HIDETHEWORD
public class Word
{
    
    private string _user = "Press enter to continue or type 'quit' to end the program.";

    private string _scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
    
    private string _thankUser = "Thank you for using the Scripture Memorizer!";
    public Word()
    {        
    }

    public void ShowUser()
    {
        Console.WriteLine($"\n{_user}");
        string userChoice = Console.ReadLine();
        
        if (userChoice != "quit")
        {
        int i = 0;
        Console.WriteLine($"{_scripture.Replace(" ","_")}");
        i++;
        
    

        if (userChoice == "quit")
    
        Console.WriteLine($"{_thankUser}");
    }
}
}