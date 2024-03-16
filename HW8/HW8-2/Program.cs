using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace HW8_2;

class Program
{
    static void Main(string[] args)
    {
        string path = "num.txt";
        Random rnd = new Random();
        int sum = 0;

        using (StreamWriter sw = new StreamWriter(path))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(rnd.Next(-77, 77));
            }
        }

        using (StreamReader sw = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(sw.ReadLine());
            }
        }

        Console.WriteLine($"Сумма чисел в файле = {sum};");
    }
}
