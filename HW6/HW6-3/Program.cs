namespace HW6_3;

public class Program
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
    /// <param name="startStr">Начальная позиция найденной подстроки. Вернёт -1 если ничего не найдёт.</param>
    /// <param name="lenStr">Длина найденной подстроки</param>
    /// <returns>Результат поиска фигурных скобок в строке</returns>
    static public bool FindStaples(string rawString, out int startStr, out int lenStr)
    {
        startStr = -1;
        lenStr = 0;
        int countStaples = 0;
        bool flag = false;

        for (int i = 0; i < rawString.Length; i++)
        {
            if (rawString[i] == '{')
            {
                if (startStr != -1)
                {
                    countStaples++;
                }
                else
                {
                    startStr = i;
                }
            }
            if (rawString[i] == '}' && startStr != -1)
            {
                if (countStaples > 0)
                {
                    countStaples--;
                }
                else
                {
                    lenStr = i - startStr + 1;
                    flag = true;
                    break;
                }
            }
        }

        // Если не нашли закрывающую скобку, то тоже возвращаем -1 как в случае когда нет ничего
        if (startStr != -1 && flag != true)
        {
            startStr = -1;
        }
        return flag;
    }
}
