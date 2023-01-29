using System;

public class Journal
{
    public List<string> _Entries = new List <string>();

    public Journal()
    {    
      
    _Entries.Add($"{1}. Write");
    _Entries.Add($"{2}. Display");
    _Entries.Add($"{3}. Load");
    _Entries.Add($"{4}. Save");
    _Entries.Add($"{5}. Quit");

    
    
    foreach (string entry in _Entries)
    {
    Console.WriteLine($"{entry}");
 
  
    }
    
        int choice = int.Parse(Console.ReadLine()); 
            if (choice == 1);
               
      
    // public AddEntry()

    // }
    }
}