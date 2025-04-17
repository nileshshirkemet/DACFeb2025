namespace DemoApp.Common;

//open generic type 
public class SimpleStack<E> : IStackReader<E>, IStackWriter<E>
{
    class Node
    {
        internal E element;
        internal Node below;
    }

    private Node top;

    public void Push(E item)
    {
        top = new Node { element = item, below = top };
    }

    public E Pop()
    {
        Node temp = top;
        top = top.below;
        return temp.element;
    }

    public bool Empty()
    {
        return top is null;
    }
}