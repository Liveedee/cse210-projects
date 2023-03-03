using System;

class Program
{
    static void Main(string[] args)
    {
    
        List<Shape> shapes = new List<Shape>();

        Square new1 = new Square("red", 3);
        Rectangle new2 = new Rectangle("blue", 4,5);
        Circle new3 = new Circle("green", 6);
        shapes.Add(new1);
        shapes.Add(new2);
        shapes.Add(new3);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }




    }
}