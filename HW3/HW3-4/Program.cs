namespace HW3_4;

class Program
{
    static void Main(string[] args)
    {
        /// 4.
        /// Дано целое число в диапазоне 100–999.
        /// Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
        /// Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.

        Console.WriteLine("Введите число от 100 до 999: ");
        int inputValue = Convert.ToInt32(Console.ReadLine());
        string hundreds;
        string dozens;
        string units;

        if (!(inputValue >= 100 && inputValue <= 999))
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка! Поворот не туда!");
            return;
        }
        #region Вычисляем сотни
        switch (inputValue / 100)
        {
            case 1:
                hundreds = "сто";
                break;
            case 2:
                hundreds = "двести";
                break;
            case 3:
                hundreds = "триста";
                break;
            case 4:
                hundreds = "четыреста";
                break;
            case 5:
                hundreds = "пятьсот";
                break;
            case 6:
                hundreds = "шестьсот";
                break;
            case 7:
                hundreds = "семьсот";
                break;
            case 8:
                hundreds = "восемьсот";
                break;
            case 9:
                hundreds = "девятьсот";
                break;
            default:
                hundreds = "";
                break;
        }
        #endregion

        #region Вычисляем десятки
        switch ((inputValue % 100) / 10)
        {
            case 2:
                dozens = "двадцать";
                break;
            case 3:
                dozens = "тридцать";
                break;
            case 4:
                dozens = "сорок";
                break;
            case 5:
                dozens = "пятьдесят";
                break;
            case 6:
                dozens = "шестьдесят";
                break;
            case 7:
                dozens = "семьдесят";
                break;
            case 8:
                dozens = "восемьдесят";
                break;
            case 9:
                dozens = "девяносто";
                break;
            default:
                dozens = "";
                break;
        }
        #endregion

        #region Вычисляем еденицы
        if ((inputValue % 100) / 10 != 1)
        {
            switch (inputValue % 10)
            {
                case 1:
                    units = "один";
                    break;
                case 2:
                    units = "два";
                    break;
                case 3:
                    units = "три";
                    break;
                case 4:
                    units = "четыре";
                    break;
                case 5:
                    units = "пять";
                    break;
                case 6:
                    units = "шесть";
                    break;
                case 7:
                    units = "семь";
                    break;
                case 8:
                    units = "восемь";
                    break;
                case 9:
                    units = "девять";
                    break;
                default:
                    units = "";
                    break;
            }
        }
        else
        {
            switch (inputValue % 100)
            {
                // Для 10-19 отдельный разговор
                case 11:
                    units = "одинадцать";
                    break;
                case 12:
                    units = "двенадцать";
                    break;
                case 13:
                    units = "тринадцать";
                    break;
                case 14:
                    units = "четырнадцать";
                    break;
                case 15:
                    units = "пятнадцать";
                    break;
                case 16:
                    units = "шестнадцать";
                    break;
                case 17:
                    units = "семнадцать";
                    break;
                case 18:
                    units = "восемнадцать";
                    break;
                case 19:
                    units = "девятнадцать";
                    break;
                default:
                    units = "";
                    break;
            }
        }
        #endregion

        Console.WriteLine($"{hundreds}{(dozens != "" ? " " + dozens : "")}{(units != "" ? " " + units : "")}");
    }
}
