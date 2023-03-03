using System;

public class Reflecting : Activity
{


    private List<string> _randomPrompt = new List<string>();
    private List<string> _randomQuestion = new List<string>();


    public Reflecting()
    {
        _randomPrompt.Add("Why was this experience meaningful to you?");
        _randomPrompt.Add("Have you ever done anything like this before?");
        _randomPrompt.Add("How did you get started?");
        _randomPrompt.Add("How did you feel when it was complete?");
        _randomPrompt.Add("What made this time different than other times when you were not as successful?");
        _randomPrompt.Add("What is your favorite thing about this experience?");
        _randomPrompt.Add("What could you learn from this experience that applies to other situations?");
        _randomPrompt.Add("What did you learn about yourself through this experience?");
        _randomPrompt.Add("How can you keep this experience in mind in the future?");

                        

    int i = 0;
    i++;
    
    foreach (string Prompt in _randomPrompt)
    {
        Console.WriteLine($"{Prompt}");
    }   
    }

    public void ShowQuestion()
    {
        _randomQuestion.Add("Think of a time when you stood up for someone else.");
        _randomQuestion.Add("Think of a time when you did something really difficult.");
        _randomQuestion.Add("Think of a time when you helped someone in need.");
        _randomQuestion.Add("Think of a time when you did something truly selfless.");
                 

    int i = 0;
    i++;
    
    
    foreach (string Question in _randomQuestion)
    {
        Console.WriteLine($"{Question}");
    }
    }   
}



    

    // public string ShowReflectingMessage()
    
    // {
    //     return $"\nWelcome to the Reflecting Activity" + "\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
    // }



    // public void DoActivity()
    // {

    // }
    // }