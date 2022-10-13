using System;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program calculate the area of a rectangle


            //rectangles values
            float sideA = 10.5f;
            int sideB = 20;

            // rectangule area formula is a*b
            float area = sideA * sideB;

            Console.WriteLine("The area of the rectangle with height: " + sideA +"cm and lenght: " + sideB + "cm is: " + area + "cm.");    

        }   
    }
}
