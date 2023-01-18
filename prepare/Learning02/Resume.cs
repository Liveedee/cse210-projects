using System;

public class Resume
{   
    List<Job> Jobs = new List<Job>();
    public string _person;

    public void DisplayAllInfo()
    {

    Console.Write($"Name: {_person}");
    Console.Write("Jobs: ");
   
    }
}   