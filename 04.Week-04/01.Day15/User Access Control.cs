using System.Security;

namespace BasicsCodeCS
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Level Score:");
            int level = int.Parse(Console.ReadLine());
            int userLevel = 0;
            if (level <= 25 && level > 0)
            {
                userLevel = level;
            }
            else
            {
                Console.WriteLine("userLevel exceeds than expected");
            }
            Console.WriteLine("Is admin or not(true/false)");
            bool admin = bool.Parse(Console.ReadLine());
            if (admin == true)
            {
                userLevel = userLevel + 50;
            }
            Console.WriteLine("Has Special Permission(true/false)");
            bool spclper = bool.Parse(Console.ReadLine());
            if (spclper == true)
            {
                userLevel = userLevel + 25;
            }

            if (userLevel < 25)
            {
                Console.WriteLine("Restricted Area");
            }
            else if (userLevel >= 75)
            {
                Console.WriteLine("FullAcces");
            }
            else if (userLevel >= 50)
            {
                Console.WriteLine("Admin access");
            }
            else
            {
                Console.WriteLine("Standard access");
            }
           
        }
    }
}
