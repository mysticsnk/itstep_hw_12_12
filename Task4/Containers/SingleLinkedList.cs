namespace Task4.Containers;

public class SingleLinkedList<T>
{
    private Node<T> _head;

    public SingleLinkedList()
    {
        _head = null;
    }

    public void Insert(int index, T item)
    {
        var newNode = new Node<T>(item);

        if (index == 0)
        {
            newNode.NextNode = _head;
            _head = newNode;
            return;
        }

        var currentNode = _head;

        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.NextNode;
        }

        var newNext = currentNode.NextNode;
        currentNode.NextNode = newNode;
        newNode.NextNode = newNext;
    }

    public void Delete(int index)
    {
        if (index == 0)
        {
            _head = _head.NextNode;
            return;
        }

        var currentNode = _head;

        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.NextNode = currentNode.NextNode.NextNode;
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
}