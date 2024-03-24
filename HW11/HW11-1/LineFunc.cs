namespace HW11_1;

public struct LineFunc
{
    double k;
    double b;

    public LineFunc(double k, double b)
    {
        this.k = k;
        this.b = b;
    }

    public double Root()
    {
        return -b / k;
    }
}
