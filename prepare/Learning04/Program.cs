using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        
        MathAssignment mathAssignment1 = new MathAssignment("Robert Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeWorkList());
    }
}