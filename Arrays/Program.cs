//ühes massiivis peab olema ainult ühte tüüpi andmed

//1.
//string[] fruit = { "apples", "bananas", "oranges" }; //string tüüpi
string[] fruit = new string[3]; //rangelt deklareeritud elementide arv - hiljem muuta ei saa

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array.");

//2.
//for (int i = 0; i < fruitArrayLength; i++)
//{
//    Console.WriteLine(fruit[i]);
//}

//3.
for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit) //foreach ainult elementide kuvamiseks - ei saa muuta
{
    Console.WriteLine(element);
}

