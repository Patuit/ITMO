namespace HW5_5;

class Program
{
    static void Main(string[] args)
    {
        /// Запросить у пользователя целочисленное значение N.
        /// Сформировать двумерный массив размера NxN следующего вида:
        // 1 0 1 0 1
        // 0 1 0 1 0
        // 1 0 1 0 1
        // 0 1 0 1 0
        // 1 0 1 0 1

        Console.WriteLine("Введите целочисленное значение N");
        int N = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                // Вариант покороче с тернарником
                // array[i, j] = ((i % 2 == 0 && j % 2 == 0) /* нечётная строка и столбец */ || (i % 2 != 0 && j % 2 != 0) /* чётная строка и столбец */) ? 1 : 0;
                
                if ((i % 2 == 0 && j % 2 == 0) /* нечётная строка и столбец */ || (i % 2 != 0 && j % 2 != 0) /* чётная строка и столбец */)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    array[i, j] = 1;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.White;
                    array[i, j] = 0;
                }
                Console.Write($"{array[i, j]}");
                Console.BackgroundColor = default;
            }
            Console.WriteLine();
        }
    }
}
