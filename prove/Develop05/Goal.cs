using System.IO;

public class Goal
{
    public List<Goal> goals = new List<Goal>();
    protected string _name;
    // private string _description;
    // private int _points;

   

    public Goal()
    {
        // goals.Add(new SimpleGoal());
        goals.Add(new EternalGoal());
        goals.Add(new ChecklistGoal());


    foreach(Goal goal in goals)
    {
        string fileName = "myGoals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        outputFile.WriteLine(_name);
    }

        
    }
    public string GetGoalName()
    {
        return $"What is the name of your goal?:";
    
    }

    // public void SetName();
    // {
        
    // }

    public string GetDescription()
    {
        return $"What is the description of your goal?";
    }
}
    // public void SetDescription();
    // {

    // }

    // public string GetPoints();
    // {

    // }

    // public void SetPoints();
    // {

    // }

    // public abstract string DisplayGoal();
    // {

    // }