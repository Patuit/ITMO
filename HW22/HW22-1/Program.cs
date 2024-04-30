namespace HW22_1;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите длинну масива:");
        int sizeArray = Convert.ToInt32(Console.ReadLine());

        // Формирование массива из случайных чисел, с заданной длинной
        Func<object, int[]> funcGetArray = new Func<object, int[]>(GetArray);
        Task<int[]> taskGetArray = new Task<int[]>(funcGetArray, sizeArray);

        // Вывод массива на экран (вот тут некотый нюанс - иногда вывод массива "разрывает". Это из-за параллельного ваполнения, понимаю, но что можно сделать?)
        Action<Task<int[]>> actionPrint = new Action<Task<int[]>>(PrintArray);
        Task taskPrint = taskGetArray.ContinueWith(actionPrint);

        // Вычисление суммы элементов в массиве
        Func<Task<int[]>, int> funcGetSumArray = new Func<Task<int[]>, int>(GetSumArray);
        Task<int> taskGetSumArray = taskGetArray.ContinueWith(funcGetSumArray);

        // Вычисление максимального элемента массива
        Func<Task<int[]>, int> funcGetMaxElementArray = new Func<Task<int[]>, int>(GetMaxElementArray);
        Task<int> taskGetMaxElementArray = taskGetArray.ContinueWith(funcGetMaxElementArray);

        taskGetArray.Start();

        Console.WriteLine($"\n\n\nРезультат вычислений:\nСумма элементов в массиве = {taskGetSumArray.Result}");
        Console.WriteLine($"Максимальное число в массиве = {taskGetMaxElementArray.Result}\n\n");

    }

    static int[] GetArray(object sizeArray)
    {
        int n = (int)sizeArray;
        int[] array = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(0, 100);
        }
        return array;
    }

    static int GetSumArray(Task<int[]> task)
    {
        int[] array = task.Result;
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
            Console.WriteLine($"Добавление элемента {item} в сумму {sum}.");
            Thread.Sleep(500);
        }
        return sum;
    }

    static int GetMaxElementArray(Task<int[]> task)
    {
        int[] array = task.Result;
        int maxElement = array[0];
        foreach (var item in array)
        {
            Console.WriteLine($"\t\t\t\t\tСравнение {item} с {maxElement}.");
            Thread.Sleep(500);
            if (item > maxElement)
            {
                maxElement = item;
            }
        }
        return maxElement;
    }
    static void PrintArray(Task<int[]> task)
    {
        int[] array = task.Result;
        Console.Write("Массив:");
        foreach (var item in array)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine(";");
    }
}
