class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Second constructor

    public override double RecordEvent()
    {
        Console.WriteLine($"Congratulations, you completed your task! You have earned {_points} points!");
        return _points;
    }


}