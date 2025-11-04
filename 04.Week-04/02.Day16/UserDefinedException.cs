// 5.  Update the above program by add user defined exception : NegativeNumberException. 

namespace Day16
{
    // User-defined exception
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }
    internal class UserDefinedException
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
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value < 0)
                        throw new NegativeNumberException("Negative numbers are not allowed!");
                    numbers[i] = value;

                }

                Console.WriteLine("Array elements:");
                foreach (int num in numbers)
                    Console.Write(num + " ");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number entered is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }

    }     
}
