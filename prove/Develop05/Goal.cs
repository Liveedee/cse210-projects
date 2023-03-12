using System.IO;

public class Goal
{
    public List<Goal> goals = new List<Goal>();
    protected string _name;
    private string _description;
    private int _points;


   

    public Goal()
    {
        Console.WriteLine($"What is the name of your goal?:");
        _name = Console.ReadLine();
        Console.WriteLine($"What is the description of your goal?:");
        _description = Console.ReadLine();
    }

    public string GetGoalName()
    {
        return _name;
    
    }

    // public void SetName();
    // {
        
    // }

    public string GetDescription()
    {
        return _description;
    }

    // public void SetDescription();
    // {

    // }

    public string GetPoints()
    {
        return $"What is the amount of points associated with this goal?:";
    }

    // public void SetPoints();
    // {

    // }

    // public abstract string DisplayGoal();
    // {

    // }
}