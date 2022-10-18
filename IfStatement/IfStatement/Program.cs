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
            else if (anyValue == 7)
            {
                message = "You are over CRAZY!";
            }
            else
            {
                message = "Bad luck bro";
            }
            Console.WriteLine($"The Answer is: {message}");

        }
    }
}
