namespace HW14_1;

public class Cat : Animal
{
    public Cat(string nameAnimal) : base(nameAnimal)
    {
        NameAnimal = nameAnimal;
    }

    public override string NameAnimal { get; init; }

    public override string Say()
    {
        return "Маууууу!";
    }
}
