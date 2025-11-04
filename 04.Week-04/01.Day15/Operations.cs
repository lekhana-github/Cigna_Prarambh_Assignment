using System.Security;

namespace BasicsCodeCS
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\n=== MENU DRIVEN LOOP EXAMPLE ===");
                Console.WriteLine("1. Even Numbers");
                Console.WriteLine("2. Odd Numbers");
                Console.WriteLine("3. Multiples of 5");
                Console.WriteLine("4. Custom Numbers");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEven Numbers from 1 to 50:");
                        for (int i = 2; i <= 50; i += 2)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("\nOdd Numbers from 1 to 50:");
                        for (int i = 1; i <= 50; i += 2)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("\nMultiples of 5 from 1 to 100:");
                        for (int i = 5; i <= 100; i += 5)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("\nEnter Start Number: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("Enter End Number: ");
                        int end = int.Parse(Console.ReadLine());
                        Console.Write("Enter Step Value: ");
                        int step = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nNumbers from {start} to {end} (step {step}):");
                        for (int i = start; i <= end; i += step)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("\nExiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
