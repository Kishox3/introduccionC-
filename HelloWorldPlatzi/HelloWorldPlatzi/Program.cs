using System;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Platzi!");

            int height = 165;
            int age = 22;
            string name = "Eduardo Peraza";
            string information = "The requested info is: \n User name: " + name  + "\n User age: " + age + "\n User height: " + height;
            Console.WriteLine(information);    
        }
    }
}
