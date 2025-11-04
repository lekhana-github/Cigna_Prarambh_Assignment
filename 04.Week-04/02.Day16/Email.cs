// 1.   Create  a C# program to implement the following requirement :  
// 				a.  Build an Email Sender simulator to explore default, and optional parameters in C#. 
// 				b.  The method should allow flexible calling with or without specifying all arguments. 
// 				c.  Parameters:  Sender, Recipient, Subject, Message, IsImportant
				
// 				Hint : Only one method to define the address the requirement

using System.Security;

namespace Day16
{
    internal class Email
    {
        // Method with optional parameters
        static void SendEmail(
            string sender,
            string recipient,
            string subject = "No Subject",
            string message = "No Message",
            bool isImportant = false)
        {
            Console.WriteLine("----- Email Details -----");
            Console.WriteLine($"From: {sender}");
            Console.WriteLine($"To: {recipient}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Important: {(isImportant ? "Yes" : "No")}");
            Console.WriteLine("-------------------------\n");
        }
        static void Main(string[] args)
        {
            // Calling with all parameters
            SendEmail("lekhanak@gmail.com", "sanju@gmail.com.com", "Meeting", "Let's meet at 5 \n PM", true);

            // Calling with only required parameters
            SendEmail("anu@example.com", "manu@example.com");

            // Calling with some optional ones
            SendEmail("sanu@example.com", "sonu@example.com", message: "Good morning!");
        }
    }
}
