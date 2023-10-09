using GenericList.Models;
using GenericList.Strategies;

namespace GenericList.Display 
{
    public class LinkedListDisplay<T> where T : IEquatable<T>
    {
        private readonly MyLinkedList<T> _linkedList;

        public LinkedListDisplay(MyLinkedList<T> mylinkedList)
        {
            _linkedList = mylinkedList ?? throw new ArgumentNullException(nameof(mylinkedList));
        }

        // Displays all node data in the list
        public void Display()
        {
            Node<T>? current = _linkedList.Head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}