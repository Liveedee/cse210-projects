public class Program

{
static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2019;
    job1._endYear = 2022;
    job1.DisplayJobDetails();
    

    Job job2 = new Job();
    job2._company = "Apple";
    job2._jobTitle = "Manager";
    job2._startYear = 2022;
    job2._endYear = 2023;
    job2.DisplayJobDetails();
    
    Resume currentResume = new Resume();
    currentResume.Jobs.Add(job1);
    currentResume.Jobs.Add(job2);

    currentResume._person = "Alison Rose";

    Console.WriteLine(currentResume.Jobs[0]._jobTitle);    
    


}
}

