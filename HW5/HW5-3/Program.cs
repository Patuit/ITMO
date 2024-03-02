namespace HW5_3;

class Program
{
    static void Main(string[] args)
    {
        /// Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
        /// Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.

        const int lenArr = 10;
        int[] array = new int[lenArr];
        Random rnd = new Random();

        Console.Write("Массив исходный: ");
        for (int i = 0; i < lenArr; i++)
        {
            array[i] = rnd.Next(-50, 50);
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < lenArr / 2 - 1; i++)
        {
            for (int j = i + 1; j < lenArr / 2; j++)
            {
                if (array[j] < array[i])
                {
                    int tempMin = array[i];
                    array[i] = array[j];
                    array[j] = tempMin;
                }

            }
        }

        for (int i = lenArr / 2; i < lenArr - 1; i++)
        {
            for (int j = i + 1; j < lenArr; j++)
            {
                if (array[j] > array[i])
                {
                    int tempMax = array[i];
                    array[i] = array[j];
                    array[j] = tempMax;
                }
            }
        }
        Console.WriteLine();
        Console.Write("Отсортированный массив: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

    }
}
