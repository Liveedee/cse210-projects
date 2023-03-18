using System;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {

    Journal journal = new Journal();
    
    
    PromptGenerator promptGenerator = new PromptGenerator();
    Console.WriteLine("What would you like to do?");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Random random = new Random();  
        Entry entry1 = new Entry();
        int promptList = random.Next(entry1._Entries.Count);
        Console.WriteLine(entry1._Entries[promptList]);
        string userEntry = Console.ReadLine();
      

        string fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
       
            outputFile.WriteLine(userEntry);
            
}
       
        
    }    


    }
    }
