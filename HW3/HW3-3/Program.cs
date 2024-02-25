namespace HW3_3;

class Program
{
    static void Main(string[] args)
    {
        /// 3.
        /// Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
        /// Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
        /// например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».
        /// Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.

        Console.WriteLine("Введите Ваш возраст: ");
        byte age = Convert.ToByte(Console.ReadLine());
        string endingAge;

        if (!(age >= 20 && age <= 69))
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Введён неверный возраст.");
            return;
        }

        switch (age % 10)
        {
            case 1:
                endingAge = "год";
                break;
            case 2:
            case 3:
            case 4:
                endingAge = "года";
                break;
            // Большой дипозон сбрасываем в дефолт это 0 и от 5 до 9
            default:
                endingAge = "лет";
                break;
        }

        Console.WriteLine($"В этот день родили меня на свет, мне сегодня {age} {endingAge}!!!");
    }
}
