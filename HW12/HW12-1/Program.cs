namespace HW12_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Вычисление периметра, площади круга по радиусу.\nВведите радиус: ");
        do
        {
            try
            {
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"P = {MathCircle.GetCircumference(r):F3}, S = {MathCircle.GetScuare(r):F3}");
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Неккоректный ввод. Попробуйте ввести ещё раз:");
            }
        } while (true);

        Console.WriteLine("Проверка принадлежности точки(x, y) к кругу с центром(x0, y0) и заданным радиусом.");

        do
        {
            try
            {
                Console.WriteLine("Введите координату точки x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату точки y:");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату центра круга x0:");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату центра круга y0:");
                double y0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите радиус круга:");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(MathCircle.GetInlineCircle(r, x0, y0, x, y) ? $"Точка({x}, {y}) принадлежит кругу с центром ({x0}, {y0}) и радиусом {r}." : "");
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Неккоректный ввод. Попробуйте ввести ещё раз:");
            }
        } while (true);

    }
}
