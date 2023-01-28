using System;

public class Entry
{

public string _write = "";
public string _display ="";
public string _load = "";
public string _save ="";
public string _quit ="";
public string _Entries;
public Entry()
{

}
public void ShowMainOption()
{
    Console.WriteLine("Welcome to the program!");
    Console.WriteLine($"{1}. Write");
    Console.WriteLine($"{2}. Display");
    Console.WriteLine($"{3}. Load");
    Console.WriteLine($"{4}. Save");
    Console.WriteLine($"{5}. Quit");
    Console.WriteLine("What would you like to do today?: ");
    
    
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1);
        Console.WriteLine();
    

    
   
}

}