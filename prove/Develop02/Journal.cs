using System;

public class Journal
{
    public List<string> _Menu = new List <string>();
    public string entry;
    public int choice;

    public Journal()
    {    
      
        _Menu.Add($"{1}. Write");
        _Menu.Add($"{2}. Display");
        _Menu.Add($"{3}. Load");
        _Menu.Add($"{4}. Save");
        _Menu.Add($"{5}. Quit");

    int i = 0;
    i++;
    foreach (string menu in _Menu)
    {
    Console.WriteLine($"{menu}"); 
    
    }
       
    // int choice = int.Parse(Console.ReadLine()); 
    
 
    }

        
    


      
    // public AddEntry()

    // }
    }
