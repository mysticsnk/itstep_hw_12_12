namespace Task2.Containers;

public class PriorityQue<T>
{
    private PQueItem<T>[] _items;

    public PriorityQue(PQueItem<T>[] items) => _items = items;

    public void Print()
    {
        if (_items.Length == 0) 
            throw new InvalidOperationException("Priority queue is empty.");
        foreach (PQueItem<T> item in _items)
            Console.Write($"{item.Value} -- {item.Priority}  ");
        
        Console.WriteLine();
    }

    public void Append(PQueItem<T> item)
    {
        var newItems = new PQueItem<T>[_items.Length + 1];
        _items.CopyTo(newItems, 0);
        newItems[_items.Length] = item;
        _items = newItems;
    }

    public T Pop()
    {
        // Буквально копія ExtractMax але pop просто звучить природно для черги, тож вирішив реалізувати і те і те
        return ExtractMax();
    }

    public T Maximum()
    {
        PQueItem<T> currentMaxItem = _items[0];
        
        foreach (PQueItem<T> item in _items)
            if (item.Priority > currentMaxItem.Priority)
                currentMaxItem = item;
        
        return currentMaxItem.Value;
    }
    
    public T Minimum()
    {
        PQueItem<T> currentMinItem = _items[0];
        
        foreach (PQueItem<T> item in _items)
            if (item.Priority < currentMinItem.Priority)
                currentMinItem = item;
        
        return currentMinItem.Value;
    }

    public T ExtractMax()
    {
        PQueItem<T> currentMaxItem = _items[0];
        
        foreach (PQueItem<T> item in _items)
            if (item.Priority > currentMaxItem.Priority)
                currentMaxItem = item;
        
        // Це щоб скопіювати у кінцевий арр усі елементи крім максимального
        PQueItem<T>[] resultArr = new PQueItem<T>[_items.Length - 1];
        for (int i = 0, j = 0; j < resultArr.Length; i++, j++)
        {
            if (_items[i] != currentMaxItem)
                resultArr[j] = _items[i];
            else j--;
        }
        
        _items = resultArr;

        return currentMaxItem.Value;
    }
    
    public T ExtractMin()
    {
        PQueItem<T> currentMinItem = _items[0];
        
        foreach (PQueItem<T> item in _items)
            if (item.Priority < currentMinItem.Priority)
                currentMinItem = item;
        
        // Це щоб скопіювати у кінцевий арр усі елементи крім мінімального
        PQueItem<T>[] resultArr = new PQueItem<T>[_items.Length - 1];
        for (int i = 0, j = 0; j < resultArr.Length; i++, j++)
        {
            if (_items[i] != currentMinItem)
                resultArr[j] = _items[i];
            else j--;
        }
        
        _items = resultArr;

        return currentMinItem.Value;
    }
    
    
}