using System;

public class Journal
{
    public List<string> _Entries = new List <string>();
    public string entry;
    public int choice;

    public Journal()
    {    
      
    _Entries.Add($"{1}. Write");
    _Entries.Add($"{2}. Display");
    _Entries.Add($"{3}. Load");
    _Entries.Add($"{4}. Save");
    _Entries.Add($"{5}. Quit");

    int i = 0;
    while (choice != 5)
    
    foreach (string entry in _Entries)
    {
    Console.WriteLine($"{entry}");
    }
    {    
    int choice = int.Parse(Console.ReadLine()); 
    i++;
    
 
    }

        
    


      
    // public AddEntry()

    // }
    }
}