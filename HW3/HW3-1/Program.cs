namespace HW3_1;

class Program
{
    static void Main(string[] args)
    {
        /// 1.
        /// Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям.
        /// Найти координаты его четвертой вершины.
        /// Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,
        /// параллельными координатным осям, вывести соответствующее сообщение.
        
        Console.WriteLine("Введите поочерёдно целочисленные координаты трех вершин прямоугольника(каждое число через Enter):");
        int pointX1 = Convert.ToInt32(Console.ReadLine());
        int pointY1 = Convert.ToInt32(Console.ReadLine());
        int pointX2 = Convert.ToInt32(Console.ReadLine());
        int pointY2 = Convert.ToInt32(Console.ReadLine());
        int pointX3 = Convert.ToInt32(Console.ReadLine());
        int pointY3 = Convert.ToInt32(Console.ReadLine());

        if ((pointX1 == pointX2 || pointX3 == pointX1 || pointX2 == pointX3) && (pointY1 == pointY2 || pointY3 == pointY1 || pointY2 == pointY3))
        {
            int pointX4 = (pointX1 == pointX2) ? pointX3 : (pointX1 == pointX3) ? pointX2 : pointX1;
            int pointY4 = (pointY1 == pointY2) ? pointY3 : (pointY1 == pointY3) ? pointY2 : pointY1;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nКоординаты четвёртой точки: ({pointX4},{pointY4}).");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Что-то не то Вы ввели Уважаемый..");
        }

    }
}
