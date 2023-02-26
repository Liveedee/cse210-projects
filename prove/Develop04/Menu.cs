using System;

    public class Menu
{
    
    public List<string> _Activities = new List<string>();




    public Menu()
    {
        _Activities.Add($"{1}. The Breathing Activity");
        _Activities.Add($"{2}. The Reflecting Activity");
        _Activities.Add($"{3}. The Listening Activity");
        _Activities.Add($"{4}. Quit The Program");


        
    int i = 0;
    i++;
    foreach (string activity in _Activities)
    {
        Console.WriteLine($"{activity}");
    }   
        
}
}