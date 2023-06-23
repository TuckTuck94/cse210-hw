class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override double RecordEvent()
    {
        _iscomplete = true;
        // print out how many points the user earned
        return _points;
    }


}
