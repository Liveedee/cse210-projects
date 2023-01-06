
// !!!!!!!!!!!! CORE REQUIREMENTS #1 AND #2 !!!!!!!!!!!!!!!!!!!!!!


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("What is your grade percentage? ");
//         string grade = Console.ReadLine();
//         int percentage = int.Parse(grade);
// {
//     if (percentage >= 90 )
//         Console.WriteLine("Your letter grade is: A"); 
//     else if (percentage >= 80)
//         Console.WriteLine("Your letter grade is: B");
//     else if (percentage >= 70)
//        Console.WriteLine("Your letter grade is: C");
//     else if (percentage >= 60)
//         Console.WriteLine("Your letter grade is: D");
//     if (percentage < 60)
//         Console.WriteLine("Your letter grade is: F");
//     if (percentage >= 60)
//         Console.WriteLine("Congratualtions! You passed! You are awesome!");
//     else
//         Console.WriteLine("I am so sorry. :( Please try again! I know you can do this! I am so proud of you no matter what!");   
//     }
// }
// }



// !!!!!!!!!!!!!!!!!!!!!! CORE REQUIREMENTS #3 !!!!!!!!!!!!!!!!!

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int percentage = int.Parse(grade);
{
    if (percentage >= 90 )
    grade = "A";
    else if (percentage >= 80)
    grade = "B";
    else if (percentage >= 70)
    grade = "C";
    else if (percentage >= 60)
    grade = "D";
    if (percentage < 60)
    grade = "F";


    Console.WriteLine($"Your letter grade is: {grade}"); 

    if (percentage >= 60)
        Console.WriteLine("Congratulations! You passed! You are awesome!");   
    else
        Console.WriteLine("I am so sorry. :( Please try again! I know you can do this! I am so proud of you no matter what!");   
    }
}
}