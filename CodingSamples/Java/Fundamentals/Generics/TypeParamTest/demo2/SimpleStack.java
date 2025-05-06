class SimpleStack<E> {
    
    //inner member class
    class Node {

        E element;
        Node below;

        Node(E value) {
            element = value;
            below = top;
        }
    }

    private Node top;

    public void push(E item) {
        top = new Node(item);
    }

    public E pop() {
        Node temp = top;
        top = top.below;
        return temp.element;
    }

    public boolean empty() {
        return top == null;
    }
}
