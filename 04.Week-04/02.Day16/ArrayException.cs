// 4.  Create a c# program to Read Array of numbers from the user and try to catch the possible exceptions using try..catch block.


namespace Day16
{
    internal class ArrayException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of elements: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[size];

                Console.WriteLine("Enter the numbers:");
                for (int i = 0; i < size; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Array elements:");
                foreach (int num in numbers)
                    Console.Write(num + " ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
                Console.WriteLine($"Details: {e.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number entered is too large or too small.");
                Console.WriteLine($"Details: {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Index was outside the bounds of the array.");
                Console.WriteLine($"Details: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }

    }
}
