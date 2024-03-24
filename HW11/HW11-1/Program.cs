namespace HW11_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Решение линейного уравнения 0=kx+b");
        
        Console.Write("Введите k: ");
        double k = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        LineFunc func = new LineFunc(k, b);

        Console.WriteLine($"Ответ: x = {func.Root()}");
    }
}
