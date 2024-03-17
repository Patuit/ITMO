using System.Globalization;

namespace HW10_1;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("* Дневник наблюдения за Луной *");

            bool flag = true;

            List<Angle> joutnalMoon = new List<Angle>();

            do
            {
                #region Ввод значений

                string? input;
                DateTime day;
                do
                {
                    Console.Write("Введите дату наблюдения в формате дд.ММ.гггг (день.месяц.год): ");
                    input = Console.ReadLine();
                }
                while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out day));

                Console.Write("Введите градусы: ");
                int gradus = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите минуты: ");
                int minutes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите секунды: ");
                int seconds = Convert.ToInt32(Console.ReadLine());

                #endregion

                joutnalMoon.Add(new Angle(gradus, minutes, seconds, day));

                Console.WriteLine("Enter - продолжить, f - завершить ввод.");
                if (Console.ReadLine() == "f")
                {
                    flag = false;
                }
            } while (flag);


            Console.WriteLine("\nЖурнал наблюдений:\n");
            foreach (var item in joutnalMoon)
            {
                Console.WriteLine($"Дата наблюдения: {item.Day:D}");
                Console.WriteLine($"Угол в градусах: {item.Gradus}° {item.Minutes}′ {item.Seconds}″");
                Console.WriteLine($"Угол в радианах: {item.ToRadians():F5}");
                Console.WriteLine($"Фаза луны: {item}\n");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
