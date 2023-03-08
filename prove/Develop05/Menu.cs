using System;

public class Menu
{
    public List<string> _FirstMenu = new List<string>();

    


    public Menu()
    {    
        
        
        
        

        
        _FirstMenu.Add($"{1}. Create New Goal");
        _FirstMenu.Add($"{2}. List Goals");
        _FirstMenu.Add($"{3}. Save Goals");
        _FirstMenu.Add($"{4}. Load Goals");
        _FirstMenu.Add($"{5}. Record Goals");
        _FirstMenu.Add($"{6}. Quit");


        int i = 0;
        i++;
        foreach(string menu in _FirstMenu)
        {
            Console.WriteLine($"{menu}");

 
        }  
        
        Console.WriteLine("Select a choice from the menu:");
        

    }











    }
