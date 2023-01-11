using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magic = int.Parse(input);
        Console.Write("What is your guess? ");                
        string stringGuess = Console.ReadLine();         
        int guess = int.Parse(stringGuess);
        
        do
        {    


            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            } 
            Console.Write("What is your guess? ");                
            stringGuess = Console.ReadLine();         
            guess = int.Parse(stringGuess);
        } 
        while (guess != magic);

        
        Console.WriteLine ("You guessed it!!");
    

  
    }       

      

}       
