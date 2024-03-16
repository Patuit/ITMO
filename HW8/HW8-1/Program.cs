using System.IO;

namespace HW8_1;

class Program
{
    static void Main(string[] args)
    {
        string path = "obj";
        string [] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        foreach (var item in files)
        {
            Console.WriteLine($"{item}");
        }
    }
}
