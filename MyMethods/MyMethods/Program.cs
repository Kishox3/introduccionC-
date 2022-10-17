using System;

namespace MyMethods
{
    internal class Program
    {
        public void IntegerAddition(int a, int b) //metodo creado, es de tipo void entonces no retorna valor
        {
            int Addition = a + b;
            Console.WriteLine("El resultado es " + Addition);
        }

        public int IntegerMultiplication(int a, int b) //metodo creado, es de tipo int entonces almacena valores enteros
        {
            int Multiplication = a * b;
            return Multiplication;
        }

        public float FloatDivision(float a, float b) //solucion reto
        {
            float Division = a / b;
            return Division;
        }


        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.IntegerAddition(3, 6);

            int resultMultiplication = MyProgram.IntegerMultiplication(12, 2);
            Console.WriteLine("El resultado de la multiplicación es " + resultMultiplication);

            float resultDivision = MyProgram.FloatDivision(25f, 6.6f);
            Console.WriteLine("El resultado de la division es " + resultDivision); //solucion reto platzi
        }
    }
}
