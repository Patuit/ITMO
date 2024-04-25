namespace HW20_1;

class Program
{
    delegate double MyDelegate(double a);
    static void Main(string[] args)
    {
        MyDelegate myDelegate = CircumferenceOfTheCircle;
        Console.WriteLine($"Длина окружности с заданным радиусом 5.14 будет равняться: {myDelegate(5.14):F5}.");
        myDelegate = AreaOfTheCircle;
        Console.WriteLine($"Площадь круга с заданным радиусом 83.28 будет равняться: {myDelegate(83.28):F5}.");
        myDelegate = VolumeOfTheBall;
        Console.WriteLine($"Объём шара с заданным радиусом 73.54 будет равняться: {myDelegate(73.54):F5}.");
    }


    static double CircumferenceOfTheCircle(double r) => 2 * Math.PI * r;
    static double AreaOfTheCircle(double r) => Math.PI * Math.Pow(r, 2);
    static double VolumeOfTheBall(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);
}
