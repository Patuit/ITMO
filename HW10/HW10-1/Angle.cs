namespace HW10_1;

public class Angle
{
    private int _gradus;
    private int _minutes;
    private int _seconds;

    public DateTime Day { get; set; }

    public int Gradus
    {
        get
        {
            return _gradus;
        }
        set
        {
            if (value < 360 && value >= 0)
            {
                _gradus = value;
            }
            else
            {
                throw new Exception("Ошибка. Неверно задаётся градус угла.");
            }
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value < 60 && value >= 0)
            {
                _minutes = value;
            }
            else
            {
                throw new Exception("Ошибка. Неверно задаются минуты угла.");
            }
        }
    }
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            if (value < 60 && value >= 0)
            {
                _seconds = value;
            }
            else
            {
                throw new Exception("Ошибка. Неверно задаются секунды угла.");
            }
        }
    }

    public Angle(int gradus, int minutes, int seconds, DateTime day)
    {
        Gradus = gradus;
        Minutes = minutes;
        Seconds = seconds;
        Day = day;
    }

    public double ToRadians()
    {
        double rad = (Gradus * Math.PI / 180) + (Minutes * Math.PI / (180 * 60)) + (Seconds * Math.PI / (180 * 3600));
        return rad;
    }

    public override string ToString()
    {
        string answer = "";
        switch (Gradus)
        {
            case >270:
                answer = "Старая Луна (Убывающий месяц)";
                break;
            case 270:
                answer = "Последняя четверть";
                break;
            case >180:
                answer = "Убывающая Луна";
                break;
            case 180:
                answer = "Полнолуние";
                break;
            case >90:
                answer = "Растущая Луна";
                break;
            case 90:
                answer = "Первая четверть";
                break;
            case 0:
                answer = "Новолуние";
                break;
            case >0:
                answer = "Молодая Луна (Растущий месяц)";
                break;
        }
        return answer;
    }
}
