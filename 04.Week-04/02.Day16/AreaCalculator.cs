using System.Security;

namespace Day16
{
    internal class AreaCalculator
    {
        // Overloaded methods for area calculations
        static double CalculateArea(double side) // Square
        {
            return side * side;
        }

        static double CalculateArea(double length, double width) // Rectangle
        {
            return length * width;
        }

        static double CalculateArea(double radius, bool isCircle) // Circle
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Geometry Utility");
            Console.WriteLine("-------------------------------------");
            double area = 0;

            Console.WriteLine("Area of Square");
            Console.Write("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            area = CalculateArea(side);
            Console.WriteLine($"Area = {area:F2}");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Area of Rectangle");
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            area = CalculateArea(length, width);
            Console.WriteLine($"Area = {area:F2}");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Area of Circle");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            area = CalculateArea(radius, true);
            Console.WriteLine($"Area = {area:F2}");  
        }       
    }
}
