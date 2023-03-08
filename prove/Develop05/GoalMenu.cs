using System;

public class GoalMenu
{
    public List<string> _SecondMenu = new List<string>();

    

    public GoalMenu()
    {
        
        Console.WriteLine($"The types of goals are:");
        
        _SecondMenu.Add($"{1}.Simple Goal");
        _SecondMenu.Add($"{2}.Eternal Goal");
        _SecondMenu.Add($"{3}.Checklist Goal");


    
        int i = 0;
        i++;
        
        
        foreach (string menu in _SecondMenu)
        {
            Console.WriteLine($"{menu}");
        }
        }   



    }
