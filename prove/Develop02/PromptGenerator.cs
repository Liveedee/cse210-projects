using System;

public class PromptGenerator
{
    public List<Entry> Entries = new List<Entry>();
    public string Entry;
  
    public string _Entries;

    public void ShowEntryOption()

    {
        foreach (Entry entry in Entries)
        {
        entry.ShowMainOption();
        }
    
}
}