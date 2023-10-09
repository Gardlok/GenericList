using GenericList.Strategies;


namespace GenericList.Models
{
    public class MyLinkedList<T> where T : IEquatable<T>
    {
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }

        // Adds a new node with the provided data
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail!.Next = newNode; 
                Tail = newNode;
            }
        }

        // Removes the node with the provided data
        public bool Remove(T data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            Node<T>? current = Head;
            Node<T>? previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous == null)
                    {
                        RemoveHead();
                    }
                    else
                    {
                        RemoveMiddleOrTailNode(previous, current);
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        private void RemoveHead()
        {
            Head = Head?.Next;
            if (Head == null)
            {
                Tail = null;
            }
        }
        private void RemoveMiddleOrTailNode(Node<T> previous, Node<T> current)
        {
            previous.Next = current.Next;
            if (current.Next == null)
            {
                Tail = previous;
            }
        }

        // Applies a processing strategy to each element in the list
        public void ProcessEachElement(IProcessingStrategy<T> strategy)
        {
            Node<T>? current = Head;
            while (current != null)
            {
                current.Data = strategy.Process(current.Data);
                current = current.Next;
            }
        }

        // Returns the number of nodes in the list
        public int Count()
        {
            int count = 0;
            Node<T>? current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}