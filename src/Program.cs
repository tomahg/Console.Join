using System;

namespace Join
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args != null && args.Length > 0 && (args[0] == "--help" || args[0] == "--help" || args[0] == "/h" || args[0] == "/help" || args.Length > 1))
            {
                Console.WriteLine();
                Console.WriteLine("Usage: join [delimiter]");
                Console.WriteLine();
                Console.WriteLine("Join will remove line breaks from whatever is piped into it.");
                Console.WriteLine("All lines will be trimmed for whitespace, and returned as a continuous string.");
                Console.WriteLine();
                Console.WriteLine("Example: type file-with-multiple-lines.txt | join");
                Console.WriteLine("         Will return the lines separated with a single space: \"a b c d\"");
                Console.WriteLine();
                Console.WriteLine("Example: type file-with-multiple-lines.txt | join \", \"");
                Console.WriteLine("         Will return the lines separated with the provided string: \"a, b, c, d\"");
                return;
            }

            string lineInput;
            string delimiterInput = args.Length == 1 ? args[0] : " ";
            string delimiter = "";
            while ((lineInput = Console.ReadLine()) != null)
            {
                Console.Write(delimiter + lineInput.Trim());
                delimiter = delimiterInput;
            }
        }
    }
}
