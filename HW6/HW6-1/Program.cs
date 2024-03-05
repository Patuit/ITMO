namespace HW6_1;

class Program
{
    static void Main(string[] args)
    {
        /// 1.
        /// Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
        /// Знаки препинания не используются. Найти самое длинное слово в строке.
        Console.WriteLine("Введите предложение без знаков препинания:");
        string? inputStr = Console.ReadLine();
        string[] strArray = inputStr.Split(" ");
        string maxLenStr = strArray[0];

        foreach (string item in strArray)
        {
            if (item.Length > maxLenStr.Length)
            {
                maxLenStr = item;
            }
        }

        Console.WriteLine($"Самое длинное слово: {maxLenStr}");
    }
}
