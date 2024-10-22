namespace ConsoleAppHT2_3;

public class Lecture : TrainingItem
{
    public string Topic { get; }

    public Lecture(string description, string? topic) : base(description)
    {
        Topic = topic ?? string.Empty;
    }

    public override TrainingItem Clone()
    {
        return new Lecture(Description, Topic);
    }
}