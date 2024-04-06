namespace HW14_1;

public class Dog : Animal
{
    public Dog(string nameAnimal) : base(nameAnimal)
    {
        NameAnimal = nameAnimal;
    }

    public override string NameAnimal { get; init; }

    public override string Say()
    {
        return "Гаф гаф!";
    }
}
