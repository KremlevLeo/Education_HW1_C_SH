//Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел./

//Обявление и чтение переменных
Console.Write("\nEnter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());
int max = 0;

//Сравнение переменных
if (a > b) max = a;
else max = b;

//Если переменные равны
if (a == b) Console.WriteLine($"\na = {a}; b = {b} -> the numbers are equal");
else Console.Write($"\na = {a}; b = {b} -> max = {max}");
