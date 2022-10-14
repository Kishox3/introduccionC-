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

//operadores relacionales


int val1 = 3;
int val2 = 18;
int val3 = -18;

bool results1 = val1 == val2;
Console.WriteLine("The result of value 1 is: " + results1);

bool results2 = val2 > val3;
Console.WriteLine("The result of value 2 is: " + results2);

bool results3 = val3 < val1;
Console.WriteLine("The result of value 3 is: " + results3);

bool results4 = val2 != val3;
Console.WriteLine("The result of value 4 is: " + results4);

bool results5 = val3 >= val1;
Console.WriteLine("The result of value 5 is: " + results5);

bool results6 = val3 <= val1;
Console.WriteLine("The result of value 6 is: " + results6);





