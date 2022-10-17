using System;

namespace RetoMetodosStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre y presionar ENTER");
            string nombreUsuario = Console.ReadLine();

            Console.WriteLine("Escribe con una palabra una cualidad de tuya");
            string cualidadUsuario = Console.ReadLine();

            string nombreMayus = nombreUsuario.ToUpper(); //METODO 1 - .ToUpper
            string cualidadMayus = cualidadUsuario.ToUpper(); 
            Console.WriteLine("Tu nombre en mayusculas es: " + nombreMayus);


            Console.WriteLine("Tu nombre tiene la vocal 'A': " + (nombreUsuario.ToUpper()).Contains("A")); //METODO 2 .Contains
            Console.WriteLine("Tu nombre tiene la vocal 'E': " + (nombreUsuario.ToUpper()).Contains("E"));
            Console.WriteLine("Tu nombre tiene la vocal 'I': " + (nombreUsuario.ToUpper()).Contains("I"));
            Console.WriteLine("Tu nombre tiene la vocal 'O': " + (nombreUsuario.ToUpper()).Contains("O"));
            Console.WriteLine("Tu nombre tiene la vocal 'U': " + (nombreUsuario.ToUpper()).Contains("U"));

            string lastLetterName = nombreUsuario.Substring(nombreUsuario.Length - 1); //METODO 3 .Substring

            Console.WriteLine(nombreMayus.Insert((nombreUsuario.LastIndexOf(lastLetterName))+1, " ES " + cualidadMayus)); //METODO 4 .Inser Y METODO 5 .LastIndexOf

        }

    }
}
