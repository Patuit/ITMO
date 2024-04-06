namespace HW15_1;

public class GeomProgression : ISeries
{
    int StepByStep { get; set; }
    int startValue = 1;
    int currentValue = 1;

    public GeomProgression(int step)
    {
        StepByStep = step;
    }
    public int GetNext()
    {
        return currentValue *= StepByStep;
    }

    public void Reset()
    {
        currentValue = startValue;
    }

    public void SetStart(int x)
    {
        startValue = x;
        currentValue = x;
    }
}
