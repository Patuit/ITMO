namespace HW4_3;

class Program
{
    static void Main(string[] args)
    {
        /// 3.
        /// Ввести положительные числа A, B, C.
        /// На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).
        /// Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.

        Console.Write("Введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        if (C == 0 || B == 0 || A == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("НЕ СМЕЙ обманывать систему, глупец! Ты ввёл НОЛЬ!!!");
            return;
        }

        if (C > A || C > B)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ни один квадрат не поместится в прямоугольник!");
            return;
        }

        int countSquare = 0;
        int countColumn = 0;
        int countLine = 0;

        while ((countLine + C) <= B)
        {
            countLine += C;
            while ((countColumn + C) <= A)
            {
                countColumn += C;
                countSquare++;
            }
            countColumn = 0; // Дошли до конца строки и сбросили счётчик, настало время начать сначала..
        }

        // Выпендрился и обошёл склонения :Р
        // Великое каверканье
        Console.WriteLine($"В прямоугольник размером {A}x{B} поместится квадратов со стороной {C} в количестве штук: {countSquare}.");
    }
}
