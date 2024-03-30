namespace HW13_1;

class Program
{
    static void Main(string[] args)
    {
        Building building1 = new Building("ул. Восстания, д. 5", 45, 23, 12);
        Console.WriteLine(building1.Print());
        MultiBuilding building2 = new MultiBuilding("ул. Кропоткина, д. 77", 35, 17, 20, 5);
        Console.WriteLine(building2.Print());
    }
}
