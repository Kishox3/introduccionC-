using System;

namespace WhileCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueSoftwareExecution = true;

            while (continueSoftwareExecution == true)
            {
                Console.WriteLine("Quieres detener el programa: Y/N");
                string response = Convert.ToString(Console.ReadLine());
                if (response == "Y" || response == "y")
                {
                    continueSoftwareExecution = false;
                }
            }
        }
    }
}
