namespace ConsoleAppHT2_3;

public abstract class TrainingItem
{
    public string Description { get; set; }

    protected TrainingItem(string description)
    {
        Description = description ?? string.Empty;
    }

    public abstract TrainingItem Clone();
}