namespace HW7_1;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Два треугольника заданы длинами своих сторон.
        Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
        Для решения задачи можно использовать формулу Герона.
        */

        int[,] arrayTriangle = { { 2, 3, 4 }, { 4, 4, 5 } };
        double maxSquare = 0;
        int numMaxSquare = 0;

        for (int i = 0; i < arrayTriangle.GetLength(0); i++)
        {
            double thisSquare = CalcSquare(arrayTriangle[i, 0], arrayTriangle[i, 1], arrayTriangle[i, 2]);

            if (thisSquare > maxSquare)
            {
                maxSquare = thisSquare;
                numMaxSquare = i + 1;
            }
        }

        Console.WriteLine($"Самая большая площадь у треугольника под номером {numMaxSquare}");
    }

    static double CalcSquare(double sideFirst, double sideSecond, double sideThird)
    {
        double triangleHalfP = (sideFirst + sideSecond + sideThird) / 2;
        return Math.Sqrt(triangleHalfP * (triangleHalfP - sideFirst) * (triangleHalfP - sideSecond) * (triangleHalfP - sideThird));
    }
}
