public class Swimming : Activity
{
    public int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        if (laps == 0)
        {
            return 5;
        }
        else
        {
            return laps * 50 / 1000;
        }
    }

    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }
}