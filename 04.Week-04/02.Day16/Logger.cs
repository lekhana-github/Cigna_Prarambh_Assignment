// 3.     Create a C# program to implement the following requirement:

// 		a.   You have a Logger class that writes messages to the console.
// 		b.  Create multiple overloaded methods for different use cases (basic message, with level, with timestamp).
// 		c.   Level :   may be INFO, WARNING, ERROR 




namespace Day16

{
    internal class Logger

    {
        // Overloaded methods

        static void Log(string message)
        {
            Console.WriteLine($"[MESSAGE]: {message}");
        }

        static void Log(string message, string level)
        {
            Console.WriteLine($"[{level}]: {message}");
        }

        static void Log(string message, string level, bool withTimestamp)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (withTimestamp)
                Console.WriteLine($"[{timestamp}] [{level}]: {message}");
            else
                Console.WriteLine($"[{level}]: {message}");
        }
        static void Main(string[] args)
        {

            Log("Application started");
            Log("Low disk space", "WARNING");
            Log("File not found", "ERROR", true);

        }

    }

}
