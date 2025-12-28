using System.ComponentModel;

namespace Task3.Containers;

public class CircularQue<T> 
{
    private T[] _items;
    public int Capacity;
    private int _readIndex = 0;
    private int _writeIndex = 0;

    public CircularQue(T[] items)
    {
        _items = items;
        Capacity = items.Length;
    }

    public CircularQue(int capacity)
    {
        _items = new T[capacity];
        Capacity = capacity;
    }

    public void ChangeCapacity(int newCapacity)
    {
        _items = new T[newCapacity];
        Capacity = newCapacity;
    }

    public void Enque(T item)
    {
        _items[_writeIndex] = item;
        _writeIndex =  (_writeIndex + 1) % Capacity;
    }

    public T Pop()
    {
        T item = _items[_readIndex];
        _items[_readIndex] = default;
        _readIndex = (_readIndex + 1) % Capacity;
        return item;
    }

    public T Peek()
    {
        T item = _items[_readIndex];
        _readIndex = (_readIndex + 1) % Capacity;
        return item;
    }

    public void Print()
    {
        foreach (T item in _items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}