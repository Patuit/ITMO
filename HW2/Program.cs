namespace HW1;

class Program
{
    static void Main(string[] args)
    {
        
        #region Расчёт радиуса и площади круга по длине окружности

            /* 
                Дана длина L окружности.
                Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
            */

            string? inputValueCircumference;
            double circumference = 0;
            double circleRadius = 0;
            double areaCircle = 0;
            bool validNumber = false;

            System.Console.Write("Введите длину окружности: ");
            inputValueCircumference = Console.ReadLine();

            validNumber = double.TryParse(inputValueCircumference, out circumference);
            if (validNumber == true)
            {
                circleRadius = circumference / (Math.PI * 2.0);
                areaCircle = Math.PI * Math.Pow(circleRadius, 2);
                Console.WriteLine($"Радиус круга равен: {circleRadius}");
                Console.WriteLine($"Площадь круга равна: {areaCircle}");
            }
            else
            {
                Console.WriteLine("Вы ввели не дробное число.");
            }

        #endregion

        #region Периметр и площадь прямоугольника

            /* 
                Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
                Стороны прямоугольника параллельны осям координат.
                Найти периметр и площадь данного прямоугольника.
            */

            // П.С. Как-то писать всю процедуру пользовательского ввода не хочется :Р 

            double recX1 = -10;
            double recY1 = -20;
            double recX2 = -5;
            double recY2 = 10;
            double sideFirstRectangle = 0;
            double sideSecondRectangle = 0;

            sideFirstRectangle = recX1 > recX2 ? recX1 - recX2 : recX2 - recX1;
            sideSecondRectangle = recY1 > recY2 ? recY1 - recY2 : recY2 - recY1;

            System.Console.WriteLine($"\n\nПериметр прямоугольника = {sideFirstRectangle * 2 + sideSecondRectangle * 2}");
            System.Console.WriteLine($"Площадь прямоугольника = {sideFirstRectangle * sideSecondRectangle}");
            
        #endregion

        #region Периметр и площадь треугольника

            /* 
                Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
                Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости.
            */

            double triangleX1 = 3;
            double triangleY1 = 1;
            double triangleX2 = -1;
            double triangleY2 = 4;
            double triangleX3 = -1;
            double triangleY3 = 1;
            double sideFirstTriangle = 0;
            double sideSecondTriangle = 0;
            double sideThirdTriangle = 0;
            double triangleP = 0;
            double triangleS = 0;
            double triangleHalfP = 0;

            sideFirstTriangle = Math.Sqrt(Math.Pow(triangleX2 - triangleX1, 2) + Math.Pow(triangleY2 - triangleY1, 2));
            sideSecondTriangle = Math.Sqrt(Math.Pow(triangleX3 - triangleX2, 2) + Math.Pow(triangleY3 - triangleY2, 2));
            sideThirdTriangle = Math.Sqrt(Math.Pow(triangleX1 - triangleX3, 2) + Math.Pow(triangleY1 - triangleY3, 2));

            triangleP = sideFirstTriangle + sideSecondTriangle + sideThirdTriangle;
            triangleHalfP = triangleP / 2.0;
            triangleS = Math.Sqrt(triangleHalfP * (triangleHalfP - sideFirstTriangle) * (triangleHalfP - sideSecondTriangle) * (triangleHalfP - sideThirdTriangle));

            System.Console.WriteLine($"\n\nПериметр треугольника = {triangleP}");
            System.Console.WriteLine($"Площадь треугольника = {triangleS}");
        #endregion
    }
}
