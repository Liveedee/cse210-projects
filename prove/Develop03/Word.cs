// HIDETHEWORD
using System;

public class Word
{

    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        hidden = false;       
    }

    public void setHidden(bool hidden)
    {
        this.hidden = hidden;

    }
    
    public bool getHidden()
    {
      return hidden;   
    }

    public void displayWord()
    {
        if (hidden == true)
        {
            foreach (char letter in word)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(word);
        }
    }
// hide 
// show
// constructor (string)

}
