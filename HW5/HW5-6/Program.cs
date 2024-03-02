namespace HW5_6;

class Program
{
    static void Main(string[] args)
    {
        /// Запросить у пользователя целочисленное значение N.
        /// Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры.
        /// Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
        /// Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

        Console.WriteLine("Введите целочисленное значение N");
        int N = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, N];

        bool flagSumRow = true;
        bool flagSumColumn = true;
        int sumDiaGen = 0;
        int sumDiaSec = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]");
                array[i, j] = Convert.ToInt32(Console.ReadLine());

                // Считаем суммы по диагоналям
                sumDiaGen += (i == j) ? array[i, j] : 0;
                sumDiaSec += (i + j == N - 1) ? array[i, j] : 0;
            }
        }

        // Выясняем, что сумма столбцов и строк между собой равна
        int sumRowOld = 0;
        int sumColumnOld = 0;
        for (int i = 0; i < N; i++)
        {
            int sumRowNew = 0;
            int sumColumnNew = 0;
            for (int j = 0; j < N; j++)
            {
                sumRowNew += array[i, j];
                sumColumnNew += array[j, i];
            }

            // Console.WriteLine($"sumRowNew = {sumRowNew}"); // Для проверки
            if (sumRowNew != sumRowOld && sumRowOld != 0)
            {
                flagSumRow = false;
            }
            sumRowOld = sumRowNew;

            // Console.WriteLine($"sumColumnNew = {sumColumnNew}"); // Для проверки
            if (sumColumnNew != sumColumnOld && sumColumnOld != 0)
            {
                flagSumColumn = false;
            }
            sumColumnOld = sumColumnNew;
        }

        // Console.WriteLine($"Сумма Побочной диагонали: {sumDiaSec}"); // Для проверки
        // Console.WriteLine($"Сумма Главной диагонали: {sumDiaGen}"); // Для проверки

        if (sumDiaSec == sumDiaGen && flagSumRow && flagSumColumn)
        {
            Console.WriteLine("Магический квадрат!");
        }
    }
}
