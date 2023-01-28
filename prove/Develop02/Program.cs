using System;

public class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        entry1._write = "How was your day?";

        Entry entry2 = new Entry();
        entry2._write = "Did anything special happen today?";

        Entry entry3 = new Entry();
        entry3._write = "Who was the most interesting person you interacted with today?";
        
        Entry entry4 = new Entry();
        entry4._write =  "Did you enjoy the weather today?";

        Entry entry5 = new Entry();
        entry5._write = "What is on your mind?";
        
        Entry currentEntry = new Entry();
        currentEntry.ShowMainOption();

        PromptGenerator currentPromptGenerator = new PromptGenerator();
        currentPromptGenerator.Entries.Add(entry1);
        currentPromptGenerator.Entries.Add(entry2);
        currentPromptGenerator.Entries.Add(entry3);
        currentPromptGenerator.Entries.Add(entry4);
        currentPromptGenerator.Entries.Add(entry5);
        currentPromptGenerator.ShowEntryOption();
        


    


    }
    }
