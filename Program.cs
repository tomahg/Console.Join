using System;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineInput;
            string delimiter = "";
            while ((lineInput = Console.ReadLine()) != null)
            {
                Console.Write(delimiter + lineInput.Trim());
                delimiter = " ";
            }
        }
    }
}
