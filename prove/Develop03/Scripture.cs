// STORETHESCRIPTURE
using System;
using System.Collections.Generic;
public class Scripture


{
    private string _scripture = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    Reference reference = new Reference();
    public List<Word> wordList = new List<Word>();
    public Scripture(Reference reference, string _scripture)
    {        
        this._scripture = _scripture;
        this.reference = reference;
        string [] lines = _scripture.Split("  ");
        foreach(string line in lines)
        {
            Word word = new Word(line);
            wordList.Add(word);
             
        }
    }
    
    // public void ShowScripture()
    // {
    //     Console.WriteLine(_scripture);
    // }
}

// split scripture