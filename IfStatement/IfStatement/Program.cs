using System;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anyValue = 7;
            string message = string.Empty;

            if (anyValue == 6)
            {
                message = "OMG are you crazy?";
            }
            else
            {
                message = "Bad luck bro";
            }
            Console.WriteLine($"The Answer is: {message}");

        }
    }
}
