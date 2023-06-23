class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    // Second constructor

    public override double RecordEvent()
    {
        // print out message
        return _points;
    }


}