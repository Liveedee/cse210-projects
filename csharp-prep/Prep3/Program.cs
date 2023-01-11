using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");

        string input = Console.ReadLine();
        string guess = Console.ReadLine();
        int magic = int.Parse(input);
        int inputGuess = int.Parse(guess);

        
    do
    {          
            if (inputGuess < magic)
            Console.WriteLine("Higher");
            if (inputGuess > magic)
            Console.WriteLine("Lower");
            if (inputGuess == magic)
            Console.WriteLine ("You guessed it!!");
        
        Console.Write("What is your guess? ");                
        string guess2 = Console.ReadLine();  
    } 
        while (inputGuess != magic);


        
  
            // guess = Console.ReadLine();

  
        }       

      
            
}       
