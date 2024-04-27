namespace HW21_1;

class Program
{
    const int n = 5;
    const int m = 3;
    static int[,] path = new int[,] { { 1, 2, 10, 2, 5 }, { 1, 2, 0, 8, 6 }, { 1, 2, 0, 4, 1 } };
    public static void GardenerBeavis()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (path[i, j] < 0)
                {
                    continue;
                }
                int delay = path[i, j];
                path[i, j] = -1;
                Thread.Sleep(delay);
            }
        }
    }
    public static void GardenerButtHead()
    {
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = m - 1; j >= 0; j--)
            {
                if (path[j, i] < 0)
                {
                    continue;
                }
                int delay = path[j, i];
                path[j, i] = -2;
                Thread.Sleep(delay);
            }
        }
    }
    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(GardenerBeavis);
        Thread thread = new Thread(threadStart);
        thread.Start();
        GardenerButtHead();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{path[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
