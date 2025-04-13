// using System;

// class AreaCalculator
// {
//     // Square
//     public int area(int a)
//     {
//         return a * a;
//     }

//     // Rectangle
//     public int area(int a, int b)
//     {
//         return a * b;
//     }

//     // Circle (Fixed the incorrect formula)
//     public double area(double radius)
//     {
//         return Math.PI * radius * radius; // Corrected formula for the area of a circle
//     }

//     // Triangle
//     public double area(double baseLength, double height)
//     {
//         return 0.5 * baseLength * height;
//     }
// }

// class Program // Renamed to follow C# naming conventions
// {
//     static void Main()
//     {
//         AreaCalculator formula = new AreaCalculator();
        
//         Console.WriteLine("Area of square: " + formula.area(30));
//         Console.WriteLine("Area of rectangle: " + formula.area(30, 50));
//         Console.WriteLine("Area of triangle: " + formula.area(33.7, 59.6));
//         Console.WriteLine("Area of circle: " + formula.area(50.89)); // Corrected method call
        
//         // Prevent console from closing immediately
//         Console.ReadLine();
//     }
// }
