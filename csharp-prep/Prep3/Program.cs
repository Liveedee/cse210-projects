using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magic = int.Parse(input);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int inputGuess = int.Parse(guess);

{
    if (inputGuess < magic)
    Console.WriteLine("Higher");
    if (inputGuess > magic)
    Console.WriteLine("Lower");
    if (inputGuess == magic)
    Console.WriteLine ("You guessed it!!");
}
    }
}
