class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}