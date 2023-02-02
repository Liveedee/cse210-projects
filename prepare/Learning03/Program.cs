using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction new1 = new Fraction();
       Console.WriteLine(new1.NewFraction());
       Console.WriteLine(new1.NewDecimal());


       Fraction new2 = new Fraction(5);
       Console.WriteLine(new2.NewFraction());
       Console.WriteLine(new2.NewDecimal());
       

       Fraction new3 = new Fraction(3, 4);
       Console.WriteLine(new3.NewFraction());
       Console.WriteLine(new3.NewDecimal());

       Fraction new4 = new Fraction(1, 3);
       Console.WriteLine(new4.NewFraction());
       Console.WriteLine(new4.NewDecimal());

    }

}