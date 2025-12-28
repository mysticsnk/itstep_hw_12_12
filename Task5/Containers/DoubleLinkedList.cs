namespace Task5.Containers;

public class DoubleLinkedList<T>
{
    private Node<T> _head;
    private Node<T> _tail;
    private int _size;

    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
        _size = 0;
    }

    public void Insert(int index, T item)
    {
        
        var newNode = new Node<T>(item);

        if (index == 0)
        {
            newNode.NextNode = _head;
            if (_head != null)
                _head.PrevNode = newNode;
            _head = newNode;
            _size++;
            
            if (_size == 1)
                _tail = _head;
            
            return;
        }

        if (index == _size)
        {
            newNode.PrevNode = _tail;
            if (_tail != null)
                _tail.NextNode = newNode;
            _tail = newNode;
            _size++;
            
            if (_size == 1)
                _head = _tail;
            
            return;
        }

        var currentNode = _head;

        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.NextNode.PrevNode = newNode;
        newNode.NextNode = currentNode.NextNode;

        currentNode.NextNode = newNode;
        newNode.PrevNode = currentNode;
        
        _size++;
    }

    public void Delete(int index)
    {
        _size--;
        if (index == 0)
        {
            _head = _head.NextNode;
            _head.PrevNode = null;
            return;
        }

        if (index == _size)
        {
            _tail = _tail.PrevNode;
            _tail.NextNode = null;
            return;
        }

        var currentNode = _head;

        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.NextNode.PrevNode = currentNode.PrevNode;
        currentNode.PrevNode.NextNode = currentNode.NextNode;
    }

    public void Print()
    {
        if (_head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        var currentNode = _head;
        while (currentNode.NextNode != null)
        {
            Console.Write($"{currentNode.Value} ");
            currentNode = currentNode.NextNode;
        }

        Console.Write($"{currentNode.Value}");
        Console.WriteLine();
    }

    public void PrintReverse()
    {
        if (_tail == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        var currentNode = _tail;
        while (currentNode.PrevNode != null)
        {
            Console.Write($"{currentNode.Value} ");
            currentNode = currentNode.PrevNode;
        }

        Console.Write($"{currentNode.Value}");
        Console.WriteLine();
    }
}