namespace HW5_1;

class Program
{
    static void Main(string[] args)
    {
        const int lengthArr = 7;
        int[] arrayNum = new int[lengthArr];
        int sumEl = 0;

        Console.WriteLine("Введите значения:");
        for (int i = 0; i < lengthArr; i++)
        {
            arrayNum[i] = Convert.ToInt32(Console.ReadLine());
            sumEl += arrayNum[i];
        }

        Console.WriteLine($"Среднее арифметическое: {(float)sumEl / lengthArr :f2}");

        // arrayNum.Average()
        // * Скрытно следит за всем тут *
    }
}
