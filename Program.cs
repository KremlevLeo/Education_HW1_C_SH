
internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu();
    }
    public static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Сomparing two numbers");
        Console.WriteLine("2) Сomparing of three numbers");
        Console.WriteLine("3) Even/Odd");
        Console.WriteLine("4) All Even");
        Console.WriteLine("5) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
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
                return true;

            case "2":
                //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                //Обявление и чтение переменных
                Console.Write("\nEnter first number: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Enter third number: ");
                int c = int.Parse(Console.ReadLine());
                max = a;

                //Сравнение переменных
                if (max < b) max = b;
                if (max < c) max = c;

                //Если переменные равны
                if (a == b && b == c) Console.WriteLine($"\na = {a}; b = {b}; c = {c} -> the numbers are equal");
                else Console.Write($"\na = {a}; b = {b}; c = {c} -> max = {max}");
                return true;

            case "3":
                //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
                Console.Write("\nEnter a number: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) Console.WriteLine($"Number {a} is a even");
                else Console.WriteLine($"Number {a} is a odd");
                return true;
            case "4":
                //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                Console.Write("\nEnter a number: ");
                a = int.Parse(Console.ReadLine());
                Console.Write($"{a} -> ");
                for(int i = 2; i<=a; i++){
                    if (i%2==0)Console.Write($"{i}, ");
                }
                return true;
            case "5":
                return false;
            default:
                return true;
        }
    }
}