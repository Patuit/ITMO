namespace HW15_1;

class Program
{
    static void Main(string[] args)
    {
        ArithProgression arithProgression = new ArithProgression(2);        
        Console.WriteLine("Арифметическая прогрессия:");
        arithProgression.SetStart(6);
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());
        Console.WriteLine(arithProgression.GetNext());

        GeomProgression geomProgression = new GeomProgression(2);
        Console.WriteLine("Геометрическая прогрессия:");
        geomProgression.SetStart(10);
        Console.WriteLine(geomProgression.GetNext());
        Console.WriteLine(geomProgression.GetNext());
        Console.WriteLine(geomProgression.GetNext());
        Console.WriteLine(geomProgression.GetNext());
    }
}
