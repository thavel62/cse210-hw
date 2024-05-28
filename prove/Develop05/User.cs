public class User
{
    public string Name { get; set; }
    public List<Goal> Goals { get; private set; }
    public int Score { get; private set; }

    public User(string name)
    {
        Name = name;
        Goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goal goal = Goals[goalIndex];
            goal.RecordEvent();
            Score += goal.Points;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
            {
                Score += checklistGoal.BonusPoints;
            }
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].Name} - {Goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {Score}");
    }

    public void SaveToFile(string filePath)
    {
        // Implement saving to file logic here
    }

    public void LoadFromFile(string filePath)
    {
        // Implement loading from file logic here
    }
}
