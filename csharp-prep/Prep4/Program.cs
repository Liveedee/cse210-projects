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
        
        do
        {
            
            numbers.Add(number); 
            add = Console.ReadLine();
            sum = int.Parse(add);
      
            // Console.WriteLine(numbers.Count);
       
            
        }
        while (number != 0);
            Console.WriteLine($"The Sum is: {sum + number}");
        
    }
}
