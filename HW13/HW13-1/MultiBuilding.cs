namespace HW13_1;

public sealed class MultiBuilding : Building
{
    public MultiBuilding(string adress, int length, int width, int height, int floors) : base(adress, length, width, height)
    {
        this.Floors = floors;
    }

    private int Floors { get; set; }

    public new string Print()
    {
        return base.Print() + $" Этажей: {Floors}.";
    }
}