using System;

class Program
{
    static void Main(string[] args)
    {    
        string scriptureVerse = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference myReference = new Reference();
        Scripture myScripture = new Scripture(myReference, scriptureVerse);
        // myScripture.ShowScripture();

        //myScripture.*Word List*.*Word Object*.*Word Methods*()
        myScripture.wordList[0].setHidden(scriptureVerse);
        myScripture.wordList[0].getHidden();
        myScripture.wordList[0].displayWord();
        //myScripture.*Word List*[*random index*].*Word Methods*()


        //WHILE Set up a while loop to run until the user enters quit or until all the words are hidden. Best to just use a while(true) loop with break points
            // CHeck is all the words are hidden, may need to build a method in Scripture to do so.
            //WHILE - Add another while loop to remove three random words from your words list. Make sure the while loop uses a counter and only incriments the counter when a word that is shown is switched to hidden. while(*variable for counting* < 3)
                // IF - add an ifstament here to do the checking of whether the word is hidden.
                    // incriment our counter

            // Display the sctripture one word at a time
            // IF - prompt the user to type quit to end the program or press enter to continue.
            // clear the console screen.

    }

}