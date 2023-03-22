using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();

        
        int entry = -1;
        while (entry != 0)
        {   
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
            string addNumber = Console.ReadLine();
            entry = int.Parse(addNumber);

            if (entry != 0)
            {
                numbers.Add(entry);
            }

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is {sum}");
    
        }

             

        int largest = numbers[0];

        foreach(int number in numbers)
        {

            if (number > largest)
            {
                largest = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {largest}");
    }
        
}