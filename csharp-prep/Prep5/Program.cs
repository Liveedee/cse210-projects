using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 
        string user = PromptUserName();
        int number = PromptUserNumber();                   
        int numberSquared = SquareNumber(number);
        DisplayAll(user, numberSquared);    
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string user = Console.ReadLine();
            return user;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayAll(string name, int square)
        {
            Console.WriteLine($"{name}, the square answer of the number you entered is: {square}");
        }

        
    }
