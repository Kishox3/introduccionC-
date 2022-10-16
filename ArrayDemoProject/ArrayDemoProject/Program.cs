using System;

namespace ArrayDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cofeeTypes;
            float[] cofeeValues;

            cofeeTypes =  new string[] {"Espresso", "Latte", "Capuccino", "Americano"};
            cofeeValues = new float[] { 1.2f, 2.5f, 2.5f, 1.2f};

            cofeeTypes[1] = "Lungo"; //con esto se puede variar un valor especifico del array

            Console.WriteLine("-- Precios de cafes --");
            for (int i = 0; i < 4; i++)
                Console.WriteLine("*" + cofeeTypes[i] + " - $" + cofeeValues[i]);  
        }
    }
}
