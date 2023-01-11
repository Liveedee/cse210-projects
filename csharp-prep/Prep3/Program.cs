using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        Console.Write("What is your guess? ");                
        string stringGuess = Console.ReadLine();         
        int guess = int.Parse(stringGuess);
        
        do
        {    


            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            } 
            Console.Write("What is your guess? ");                
            stringGuess = Console.ReadLine();         
            guess = int.Parse(stringGuess);
        } 
        while (guess != number);

        
        Console.WriteLine ("You guessed it!!");
    

  
    }       

      

}       
