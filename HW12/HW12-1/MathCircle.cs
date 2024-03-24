namespace HW12_1;

public static class MathCircle
{
    /// <summary>
    /// Вычисляет периметр круга по радиусу
    /// </summary>
    /// <param name="radius"></param>
    /// <returns>Периметр круга в double</returns>
    public static double GetCircumference(double radius)
    {
        return Math.PI * 2 * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по радиусу
    /// </summary>
    /// <param name="radius"></param>
    /// <returns>Площадь круга в double</returns>
    public static double GetScuare(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Проверка принадлежности точки(x, y) к кругу с центром(x0, y0) и заданным радиусом
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <param name="x0">Значение x центра круга</param>
    /// <param name="y0">Значение y центра круга</param>
    /// <param name="x">Значение x проверяемой точки</param>
    /// <param name="y">Значение y проверяемой точки</param>
    /// <returns>true - точка принадлежит кругу, false - не принадлежит</returns>
    public static bool GetInlineCircle(double radius, double x0, double y0, double x, double y)
    {
        return Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2) < radius;
    }
}
