// See https://aka.ms/new-console-template for more information

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco tacos de suadero");
tacoShoppingList.Add("Cuatro tacos des tripa");
tacoShoppingList.Add("Cinco tacos de pastor");
tacoShoppingList.Add("Cuatro Coca-Cola");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

Console.WriteLine("------------------");


tacoShoppingList.Remove("Cinco tacos de suadero"); //las listas buscan y comparan, no se tiene que usar posiciones como los arrays
tacoShoppingList.RemoveAt(0); //pero tambien puede funcionar por posicion

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}