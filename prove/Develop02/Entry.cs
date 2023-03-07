using System;

    public class Entry
    {

    public int choice;

    public List<string> _Entries = new List<string>();

    public Entry()
    {
        _Entries.Add("Who was the most interesting person I interacted with today?");
        _Entries.Add("What was the best part of my day?");
        _Entries.Add("How did I see the hand of the Lord in my life today?");
        _Entries.Add("What was the strongest emotion I felt today?");
        _Entries.Add("If I had one thing I could do over today, what would it be?");
            
    
    int i = 0;
    while (choice != 5)
    {
        foreach(string entry in _Entries)
        {
            Console.WriteLine($"{entry}");
        }
        int choice = int.Parse(Console.ReadLine());
        i++;
        }
    }
        
        // for (int i = 0; i < _Entries.Count; i++)
        // {         
        //     Random randomGenerator = new Random(_Entries);
        //     int entryNumber = randomGenerator.Next(_Entries);
        //     Console.WriteLine(_Entries[i]);
        // }


}

    
    // int choice = int.Parse(Console.ReadLine());

    // if (choice == 1);
    //     Console.WriteLine();
