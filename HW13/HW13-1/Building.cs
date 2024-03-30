namespace HW13_1;

public class Building
{
    private string Adress { get; set; }
    private int Length { get; set; }
    private int Width { get; set; }
    private int Height { get; set; }

    public Building(string adress, int length, int width, int height)
    {
        this.Adress = adress;
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public string Print()
    {
        return $"Адрес: {Adress}. Длина здания: {Length}. Ширина здания: {Width}. Высота здания: {Height}.";
    }
}
