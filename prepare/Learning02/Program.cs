using System;

class Program
{
    static void Main(string[] args)
    {
        Job1 job1 = new Job1();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1990;
        job1._endYear = 2002;
        job1.SeeAll();

        
    
    }
    public class Job1
{

    public string _company = "";
    public string _jobTitle = "";
    public int _startYear= 0;
    public int _endYear = 0;

    public Job1()
    {
    }
    public void SeeAll()
    {
        Console.WriteLine($"{_company}");
    }
}
    }