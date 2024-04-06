namespace HW15_1;

public class ArithProgression : ISeries
{
    int StepByStep { get; set; }
    int startValue;
    int currentValue;

    public ArithProgression(int step)
    {
        StepByStep = step;
    }
    public int GetNext()
    {
        return currentValue += StepByStep;
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
