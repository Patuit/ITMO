namespace HW6_2;

class Program
{
    static void Main(string[] args)
    {
        /// 2.
        /// вести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
        /// Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом
        /// без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

        Console.WriteLine("Введите предложение без знаков препинания:");
        string inputStr = Console.ReadLine();
        string strArray = inputStr.Replace(" ", "").ToLower();
        bool flagPolindrom = true;

        for (int i = 0; i < strArray.Length / 2; i++)
        {   
            if (strArray[i] != strArray[strArray.Length - 1 - i])
            {
                flagPolindrom = false;
            }
        }

        Console.WriteLine($"{(flagPolindrom ? "Полиндром!" : "Просто предложение")}");
    }
}
