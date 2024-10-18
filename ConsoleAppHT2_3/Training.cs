namespace ConsoleAppHT2_3;

public class Training
{
    private List<TrainingItem> _items;

    public Training()
    {
        _items = new List<TrainingItem>();
    }

    // Method to add Lecture or PracticalLesson
    public void Add(TrainingItem item)
    {
        _items.Add(item);
    }

    // Method to check if all items are practical lessons
    public bool IsPractical()
    {
        foreach (var item in _items)
        {
            if (!(item is PracticalLesson))
            {
                return false;
            }
        }
        return true;
    }

    // Method to clone the Training (deep clone)
    public Training Clone()
    {
        var clonedTraining = new Training();
        foreach (var item in _items)
        {
            clonedTraining.Add(item.Clone()); // Use Clone method from Lecture and PracticalLesson
        }
        return clonedTraining;
    }

    // Method to print the details of the training
    public void PrintTraining()
    {
        foreach (var item in _items)
        {
            if (item is Lecture lecture)
            {
                Console.WriteLine($"Lecture - Description: {lecture.Description}, Topic: {lecture.Topic}");
            }
            else if (item is PracticalLesson practicalLesson)
            {
                Console.WriteLine($"Practical Lesson - Description: {practicalLesson.Description}, Task Condition: {practicalLesson.TaskConditionLink}, Solution: {practicalLesson.SolutionLink}");
            }
        }
    }
}