using System;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program calculate the area of a rectangle

            Console.WriteLine("Insert the height in cm: ");
            float sideA = float.Parse(Console.ReadLine());      //se convierte a un tipo flotando con float.Parse

            Console.WriteLine("Insert the height in cm: ");
            float sideB = float.Parse(Console.ReadLine());

            // rectangule area formula is a*b
            float area = sideA * sideB;
            Console.WriteLine("The area of the rectangle with height: " + sideA +"cm and lenght: " + sideB + "cm is: " + area + "cm.");

            /*
            sideB++; //INCREMENTA LA VARIABLE DE 1 EN 1 CADA VEZ QUE SE EJECUTA
            sideB++;
            sideB++;
            sideB++;
            sideB--;
            */

        }
    }
}
