namespace HW6_3;

class Program
{
    static void Main(string[] args)
    {
        /// 3.
        /// Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
        /// В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
        /// Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.

        Console.WriteLine("Введите текст:");
        string? inputStr = Console.ReadLine();

        int startStr;
        int lenStr;

        while (FindStaples(inputStr!, out startStr, out lenStr))
        {
            inputStr = inputStr.Remove(startStr, lenStr);
        }
        Console.WriteLine("Строка с удалёнными фигурными скобками:");
        Console.WriteLine(inputStr);
    }

    /// <summary>
    /// Поиск символов заключенных в фигурные скобки {...}
    /// </summary>
    /// <param name="rawString">Строка для поиска</param>
    /// <param name="startStr"></param>
    /// <param name="lenStr"></param>
    /// <returns>Результат поиска фигурных скобок в строке</returns>
    static public bool FindStaples(string rawString, out int startStr, out int lenStr)
    {
        startStr = 0;
        lenStr = 0;
        int staples1 = 0;
        bool flag = false;

        for (int i = 0; i < rawString.Length; i++)
        {
            if (rawString[i] == '{')
            {
                if (startStr != 0)
                {
                    staples1++;
                }
                else
                {
                    startStr = i;
                }
            }
            if (rawString[i] == '}')
            {
                if (staples1 > 0)
                {
                    staples1--;
                }
                else
                {
                    lenStr = i - startStr + 1;
                    flag = true;
                    break;
                }
            }
        }
        return flag;
    }
}
