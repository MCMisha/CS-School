namespace ConsoleAppHT2_3;

public class PracticalLesson : TrainingItem
{
    public string TaskConditionLink { get; }
    public string SolutionLink { get; }
    public PracticalLesson(string description, string? taskConditionLink, string? solutionLink) : base(description)
    {
        TaskConditionLink = taskConditionLink ?? string.Empty;
        SolutionLink = solutionLink ?? string.Empty;
    }

    public override TrainingItem Clone()
    {
        return new PracticalLesson(this.Description, this.TaskConditionLink, this.SolutionLink);
    }
}