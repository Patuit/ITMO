namespace HW18_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку со скобками:");
        string inputStr = Console.ReadLine();
        Console.WriteLine($"Скобки в строке расставлены {(Check(inputStr) ? "" : "не")}корректно.");
    }

    static bool Check(string inputStr)
    {

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dictionary = new Dictionary<char, char> {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        foreach (char c in inputStr)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(dictionary[c]);
            }
            if ((c == ')' || c == '}' || c == ']') && (stack.Count == 0 || stack.Pop() != c))
            {
                return false;
            }
        }
        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
