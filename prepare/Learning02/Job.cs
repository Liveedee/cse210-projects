
using System;


public class Job
{
    public string _company = ""; 
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;
    public Job()
    {
        
    }

    public void SeeAll()
    {
        Console.WriteLine($"{_company}");
    }
    

    }
