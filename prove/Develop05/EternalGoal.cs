public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never marked as completed
    }

    public override string GetStatus()
    {
        return "[∞]";
    }
}
