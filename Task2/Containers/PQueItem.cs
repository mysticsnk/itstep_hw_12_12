namespace Task2.Containers;

public class PQueItem<T>
{
    public T Value { get; set; }
    public int Priority { get; set; }

    public PQueItem(T value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}