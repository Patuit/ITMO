namespace HW3_2;

class Program
{
    static void Main(string[] args)
    {
        /// 2.
        /// На числовой оси расположены три точки: A, B, C.
        /// Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.
        /// Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, совпадать с А или между собой - выдать соответствующее сообщение.

        Console.WriteLine("Введите три точки на числовой оси(целые числа через Enter):");
        Console.Write("A: ");
        int pointA = Convert.ToInt32(Console.ReadLine());
        Console.Write("B: ");
        int pointB = Convert.ToInt32(Console.ReadLine());
        Console.Write("C: ");
        int pointC = Convert.ToInt32(Console.ReadLine());

        int AB = Math.Abs(pointB - pointA);
        int AC = Math.Abs(pointC - pointA);

        if (pointA == pointB && pointA == pointC)
        {
            System.Console.WriteLine("Все три точки совпадают между собой.");
        }
        else if (pointB == pointC)
        {
            System.Console.WriteLine("Точки B и C совпадают между собой.");
        }
        else if (AB == AC)
        {
            System.Console.WriteLine("Точки B и C равноудалены от точки А.");
        }
        else {
            System.Console.WriteLine("К точке А ближе всего расположена точка " + ((AB > AC) ? "C" : "B"));
        }
    }
}
