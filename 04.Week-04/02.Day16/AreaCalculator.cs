// 2.   Create  a C# program to implement the following requirement :   
// 			a .  Design a Geometry Utility methods that calculates the area of different shapes using method overloading.
// 			b.  Invoke the methods from the Main method
// 			c.   Get the required inputs from the user. 
			
// 			Hint : Need to include the shapes :  Square, Rectangle and Circle.
// 					   --  Use Math.PI to get PI value. 



namespace Day16
{
    internal class AreaCalculator
    {
        // Overloaded methods for area calculations
        static int CalculateArea(int side) // Square
        {
            return side * side;
        }

        static double CalculateArea(double length, double width) // Rectangle
        {
            return length * width;
        }

        static double CalculateArea(double radius) // Circle
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
            int side = Convert.ToInt32(Console.ReadLine());
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
            area = CalculateArea(radius);
            Console.WriteLine($"Area = {area:F2}");  
        }       
    }
}
