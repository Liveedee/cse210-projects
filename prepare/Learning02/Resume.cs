using System;

public class Resume
{   
    
    public List<Job> Jobs = new List<Job>();
    public string _person;

    public void DisplayJobDetails()
    {

    Console.WriteLine($"Name: {_person}");
    Console.WriteLine("Jobs: ");
    
    foreach (Job job in Jobs)
    {
        job.DisplayJobDetails();
    }
}   
}