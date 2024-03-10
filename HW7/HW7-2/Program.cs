namespace HW7_2;

class Program
{
    static void Main(string[] args)
    {
        /* 
            Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        */
        Console.Write("Введите длину ребра куба: ");
        double edgeLength = Convert.ToDouble(Console.ReadLine());
        double squareCube;
        double volumeSquare;

        CalcCube(edgeLength, out squareCube, out volumeSquare);

        Console.WriteLine($"\nПлощадь куба = {squareCube:.00}\nПериметр куба = {volumeSquare:.00}");
    }

    static void CalcCube(double edgeLength, out double squareCube, out double volumeSquare)
    {
        squareCube = Math.Pow(edgeLength, 2) * 6;
        volumeSquare = Math.Pow(edgeLength, 3);
    }
}
