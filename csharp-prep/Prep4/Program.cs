using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        string add = Console.ReadLine();
        int number = int.Parse(add);
        List<int> numbers = new List<int>();
        int sum = number + number;
        int runningTotal = 0;

        do
        {
            numbers.Add(number);
            add = Console.ReadLine();
            sum = int.Parse(add);
            runningTotal += sum;
        
        if (sum == 0)
        {
            Console.Write($"The Sum is: {number + runningTotal}");
        }
            
        }
        while (sum != 0);
           
            int averageCounter = (numbers.Count);
            float average = number + runningTotal;
            Console.Write($"The average is: {average / averageCounter }");
        

    int largest = numbers[0];

    foreach(int n in numbers)
    {

        if (number > largest)
        {
            largest = n;
        }
    }
        Console.WriteLine($"The largest number is: {number}");
    }
        
}