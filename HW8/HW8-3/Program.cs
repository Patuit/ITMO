using System.IO;
namespace HW8_3;

class Program
{
    static void Main(string[] args)
    {
        string text = "Времена не выбирают,\nВ них живут и умирают.\nБольшей пошлости на свете\nНет, чем клянчить и пенять.\nБудто можно те на эти,\nКак на рынке, поменять.";
        // string text = "Времена не выбирают,В них живут и умирают.Большей пошлости на светеНет, чем клянчить и пенять.Будто можно те на эти,Как на рынке, поменять.";
        string path = "poem.txt";

        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(text);
        }
        int countString = File.ReadAllLines(path).Length;
        int countSymbol = File.ReadAllText(path).Length;
        string allText = File.ReadAllText(path);
        string [] wordsArr = allText.Split(new char[] {' ', '\n'});
        // Количество слов - 1 потому что скорее всего кодирвока с BOM и один перевод каретки всегда есть в документе
        Console.WriteLine($"Количество строк {countString};\nКоличество символов {countSymbol - 1};\nКоличество слов {wordsArr.Length - 1}.");
    }
}
