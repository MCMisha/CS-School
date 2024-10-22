namespace ConsoleAppHT2_3;

public class Training
{
    private TrainingItem[] _items;
    private int _count;
    public string Description { get; set; } 

    public Training(string description)
    {
        Description = description ?? string.Empty;
        _items = new TrainingItem[10];
        _count = 0;
    }

    public void Add(TrainingItem item)
    {
        if (_count >= _items.Length)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }

        _items[_count] = item;
        _count++;
    }

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

    public Training Clone()
    {
        var clonedTraining = new Training();
        foreach (var item in _items)
        {
            clonedTraining.Add(item.Clone());
        }
        return clonedTraining;
    }

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