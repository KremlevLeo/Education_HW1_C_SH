
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
        Console.WriteLine("3) Exit");
        Console.WriteLine("4) Exit");
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
                if (a == b && b==c) Console.WriteLine($"\na = {a}; b = {b}; c = {c} -> the numbers are equal");
                else Console.Write($"\na = {a}; b = {b}; c = {c} -> max = {max}");
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }
}