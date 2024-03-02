namespace HW5_4;

class Program
{
    static void Main(string[] args)
    {
        /// Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
        /// Определить количество нечетных положительных элементов, стоящих на четных местах.

        const int lenArr = 20;
        int[] array = new int[lenArr];
        Random rnd = new Random();
        int countOddEl = 0;

        Console.Write("Массив исходный: ");
        for (int i = 0; i < lenArr; i++)
        {
            array[i] = rnd.Next(-50, 50);
            if (i % 2 != 0) // Инверсия, т.к. с 0 начало, то чётные это нечётные получаются..
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write(array[i]);
            Console.BackgroundColor = default;
            Console.Write(" ");
        }

        for (int i = 1; i < lenArr; i+=2)
        {
            if (array[i] % 2 != 0 && array[i] > 0)
            {
                countOddEl++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Количество нечетных положительных элементов, стоящих на четных местах: {countOddEl}");
    }
}
