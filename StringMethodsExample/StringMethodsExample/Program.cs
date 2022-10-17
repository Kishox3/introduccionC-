using System;

namespace StringMethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string School = "Platzi";
            string House = "Casita";

            string SchoolClone = School.Clone().ToString(); //crea un clon de un string en una variable de tipo objeto
            Console.WriteLine(SchoolClone);
            Console.WriteLine(School);

            Console.WriteLine(SchoolClone.CompareTo(School)); //hace una comparacion entre dos strings, si son iguales lanza 0, si son diferentes lanza -1
            Console.WriteLine(House.CompareTo(SchoolClone));


            Console.WriteLine(School.Contains("lat")); //retorna true si el string contiene algo de lo esccrito en parentesis
            Console.WriteLine(School.EndsWith("zi")); //retorna true si el string termina con algo de lo escrito en parentesis
            Console.WriteLine(School.StartsWith("Pla")); //retorna true si el string empieza con algo de lo escrito en parentesis

            Console.WriteLine(School.Equals(SchoolClone)); //igual que compareTo, pero retora true or false

            Console.WriteLine(School.IndexOf("a")); //indica posicion del caracter especificado

            Console.WriteLine(School.ToLower()); //convierte minus
            Console.WriteLine(School.ToUpper()); //convierte mayus

            Console.WriteLine(School.Insert(6, " es educacion online efectiva")); //inserta texto segun la posicion indicada

            Console.WriteLine(School.LastIndexOf("i")); //para saber ultima posicion del caracter

            Console.WriteLine(School.Remove(4));

            Console.WriteLine(School.Replace("a", "z"));

            //investigar metodo Split()

            School.ToCharArray();

            string TextWithSpaces = "  hola, había espacios al principio y al final ";
            Console.WriteLine(TextWithSpaces.Trim());
        }
    }
}
