// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool value1 = true;
bool value2 = true;
bool value3 = false;

// && , || , !
// and , or , not

bool result1 = value1 || value2 || value3;
Console.WriteLine("The result of the logical AND is: " + result1);

bool result2 = value1 && value2 && value3;
Console.WriteLine("The result of the logical AND is: " + result2);

bool result3 = !value1; //el not es lo inverso al valor booleano
Console.WriteLine("The result of the logical AND is: " + result3);