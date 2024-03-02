namespace HW5_2;

class Program
{
    static void Main(string[] args)
    {
        const int lengthArr = 10;
        int[] arrayNum = new int[lengthArr];
        Random rnd = new Random();

        for (int i = 0; i < lengthArr; i++)
        {
            arrayNum[i] = rnd.Next(0, 99);
        }
        int minEl = arrayNum[0];
        int maxEl = arrayNum[0];
        
        Console.Write("Массив: ");
        foreach (var item in arrayNum)
        {
            Console.Write(item + " ");
            if (item < minEl)
            {
                minEl = item;
            }
            
            if (item > maxEl)
            {
                maxEl = item;
            }
            
        }
        Console.WriteLine();
        Console.WriteLine($"Минимальный элемент: {minEl}\nМаксимальный элемент: {maxEl}"); 
    }
}
