using System;

public class Menu
{
    public List<string> _firstMenu = new List<string>();

    


    public Menu()
    {  
        
        _firstMenu.Add($"{1}. Create New Goal");
        _firstMenu.Add($"{2}. List Goals");
        _firstMenu.Add($"{3}. Save Goals");
        _firstMenu.Add($"{4}. Load Goals");
        _firstMenu.Add($"{5}. Record Goals");
        _firstMenu.Add($"{6}. Quit");


        int i = 0;
        i++;
        foreach(string menu in _firstMenu)
        {
            Console.WriteLine($"{menu}");

 
        }  
        
        Console.WriteLine("Select a choice from the menu:");
        

    }











    }
