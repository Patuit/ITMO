namespace HW14_1;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Шарик");
        Console.WriteLine(dog.ShowInfo());

        Cat cat = new Cat("Барсик");
        Console.WriteLine(cat.ShowInfo());
    }
}
