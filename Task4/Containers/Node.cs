namespace Task4;

public class Node<T>
{
    public T Value { get; set; }
    private Node<T> nextNode;
    
    public Node(T value)
    {
        Value = value;
    }
}