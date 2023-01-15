using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();            
        
        
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static void PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            Console.ReadLine();
        }
        static void PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            Console.ReadLine();
        }
        // static void SquareNumber()
        // {

        // }


    }
