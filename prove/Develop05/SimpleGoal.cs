using System;



public class SimpleGoal : Goal
{
    private string _simpleName = Console.ReadLine();
    
    public string GetName()
    {
        return _simpleName;
    }

    public void SetSimple(string simpleName)
    {
        _simpleName = simpleName;
    }
    

}