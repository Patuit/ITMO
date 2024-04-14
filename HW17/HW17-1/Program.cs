namespace HW17_1;

class Program
{
    static void Main(string[] args)
    {
        ChetBank<string> chet1 = new();
        chet1.Input();
        chet1.ReadInfo();
        ChetBank<int> chet2 = new();
        chet2.Input();
        chet2.ReadInfo();
    }
}
