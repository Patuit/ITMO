namespace HW23_1;

class Program
{
    static void MethodFactorial(int n)
    {
        int factorial = 1;
        Console.WriteLine("Method Factorial Start");
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            Console.WriteLine($"Method Factorial - {i}");
            Thread.Sleep(500);
        }
        Console.WriteLine("Method Factorial End");
        Console.WriteLine($"Факториал числа = {factorial}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число для получиления факториала:");
        int n = Convert.ToInt32(Console.ReadLine());
        MethodFactorialAsync(n);
        Console.WriteLine("Main the END");
        Console.ReadLine();
    }

    static async void MethodFactorialAsync(int n)
    {
        await Task.Run(() => MethodFactorial(n));
    }
}
