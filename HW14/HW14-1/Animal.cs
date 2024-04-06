namespace HW14_1;

public abstract class Animal
{
    public abstract string NameAnimal { get; init; }

    public Animal(string nameAnimal)
    {
        NameAnimal = nameAnimal;
    }

    public abstract string Say();

    public string ShowInfo()
    {
        return $"{NameAnimal}, {Say()}";
    }
}
