namespace HW4_2;

class Program
{
    static void Main(string[] args)
    {
        /// 2.
        /// Осуществить ввод последовательности целых чисел и сравнить,
        /// что больше, количество положительных или количество отрицательных.
        /// Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
        int inputValue = 0;
        int sumPositiveNum = 0;
        int sumNegativeNum = 0;
        do
        {
            Console.Write("Введите число: ");
            inputValue = Convert.ToInt32(Console.ReadLine());
            if (inputValue > 0)
            {
                sumPositiveNum += inputValue;
            }
            else {
                sumNegativeNum += Math.Abs(inputValue);
            }
        } while (inputValue != 0);
        Console.WriteLine($"{(sumPositiveNum > sumNegativeNum ? "Сумма положительных больше" : sumPositiveNum < sumNegativeNum ? "Сумма отрицательных больше" : "Суммы равны")}!\nСумма положительных = {sumPositiveNum}\nСумма отрицательных = {sumNegativeNum}");
    }
}
