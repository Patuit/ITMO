namespace HW17_1;

public class ChetBank<T>
{
    private T num;
    private int balance;
    private string name;

    public void Input()
    {
        Console.WriteLine("Введите номер счёта:");
        num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        Console.WriteLine("Введите баланс счёта:");
        balance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ФИО счёта:");
        name = Console.ReadLine();
    }

    public void ReadInfo()
    {
        Console.WriteLine($"Номер счёта: {num}, баланс: {balance}, ФИО: {name}.");
    }

}
