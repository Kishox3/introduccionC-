using System;

namespace ForCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo For ejecuta instrucciones en cada iteracion (cada vez que se ejecuta un codigo)

            for (int i = 0; i <= 50; i = i + 10)
            {
                Console.WriteLine("Hello World #"+i);
            } 
                
        }
    }
}
