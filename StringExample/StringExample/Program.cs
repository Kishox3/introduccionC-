using System;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name and press ENTER:");
            string fullUserName = Console.ReadLine();

            Console.WriteLine("Hello " + fullUserName + ", welcome to Platzi!");
        }
    }
}
