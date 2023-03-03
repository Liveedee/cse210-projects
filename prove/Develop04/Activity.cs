using System;

    public class Activity
{
    // private string _startMessage;
    // private string _endMessage;
    protected int _duration;
    protected string _activity;
    protected string _info;

        

        
    public void ActivityInfo(int duration, string activity, string info)
    {
        _duration = duration;
        _activity = activity;
        _info = info;
    }

    public string NameActivity()
    {
        return _activity;
    }

    public string DescriptionInfo()
    {
        return _info;
    }

    public void DoAnimation()
    {
        Console.Write("+");
        Thread.Sleep(1000);
        Console.Write("b \b");
        Console.Write("-");
    }
    


    public string GetUserTime()

    {
       return "How long, in seconds, would you like for your session?";
     
    }

    public string DisplayStart()
    {
        return $"Welcome to the {_activity} + {_info}";
    }
    
    // public string DisplayEnd()
    // {
    //     return 
    // }
}

    // public string DisplayEnd()
    // {
    //     return $"{_endMessage}";
    // }

