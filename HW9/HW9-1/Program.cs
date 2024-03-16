namespace HW9_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Калькулятор 2000 ===");
        try
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите код операции: ");
            Console.WriteLine("\t1 - сложение");
            Console.WriteLine("\t2 - вычитание");
            Console.WriteLine("\t3 - деление");
            Console.WriteLine("\t4 - умножение");
            Console.Write("код: ");
            double operation = Convert.ToDouble(Console.ReadLine());

            double answer = 0;
            switch (operation)
            {
                case 1:
                    answer = a + b;
                    break;
                case 2:
                    answer = a - b;
                    break;
                case 3:
                    // У меня не выбрасывается по умолчанию исключение деления на ноль. ХЗ почему так..
                    if (b == 0)
                    {
                        Exception exNull = new Exception("Ошибка. Делить на ноль нельзя!");
                        throw exNull;
                    }
                    answer = a / b;
                    break;
                case 4:
                    answer = a * b;
                    break;
                default:
                    Exception exNotOperation = new Exception("Ошибка. Нет операции с указанным номером.");
                    throw exNotOperation;
            }
            Console.WriteLine($"Результат: {answer}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
