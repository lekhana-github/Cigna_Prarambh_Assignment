// Assignment-1 (  Abstract Class)   Shape Hierarchy
// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Objective: Implement abstraction and polymorphism.

// Requirements:
// 		Create an abstract class Shape with:
// 						An abstract method double CalculateArea()
// 						A non-abstract method void DisplayArea() that prints the area

// Create subclasses:
// 		Circle (with radius)
// 		Rectangle (with width and height)
// 		Override CalculateArea() in each subclass.

// In Main(), create objects and call DisplayArea() for each.

namespace ObjectOrientedProgramming
{

namespace AreaCalculator
    {
        abstract class Shape
        {
            public double area;
            public abstract double CalculateArea();

            public void DisplayArea()
            {
                area = Math.Round(CalculateArea());
                Console.WriteLine($"The area of {this.GetType().Name} is: {area}");
            }
        }

        class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
        }

       
        class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double CalculateArea()
            {
                return width * height;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Shape circle = new Circle(5);
                Shape rectangle = new Rectangle(4, 6);

                circle.DisplayArea();      
                rectangle.DisplayArea();   

                Console.ReadLine();

            }

        }
    }

}


