using System;

public class PromptGenerator

{

    List<string> _promptsList = new List<string>();

    public PromptGenerator()
    {
        _promptsList.Add("How was your day?");
        _promptsList.Add("Did anything special happen today?:");
        _promptsList.Add("What is on your mind?: ");
        _promptsList.Add("Did you enjoy the weather today?");
        _promptsList.Add("Who was the most interesting person you interacted with today?:");
    }
    // public void NewRandomPrompt()
    // {
    //     Random randomPrompt = new Random();
    //     int _promptsList = randomPrompt.Next(0,10);

    //     for (int i = 0; i < 10; i++)
    //     {
    //         Console.WriteLine(i);
    // }
}
