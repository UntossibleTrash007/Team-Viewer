using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoApp
{
    internal class Queue<T> : IEnumerable<T>
    {
        public Node<T>? head { get; protected set; }
        public Queue()
        {
            head = null;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        public void Enqueue(Node<T> node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to return");
                return;
            }
            else if (head.Next == null)
            {
                head = null;
                return;
            }
            Node<T> current = head;
            head = current.Next;

        }

        public T Peek()
        {
            if (head == null)
            {
                return default(T); // Returns default value of T, e.g., null for reference types, 0 for int, etc.
            }
            return head.Item;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            int Count = 1;
            if (head == null)
            {
                return 0;
            }
            if (head != null)
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    Count++;
                }
            }
            return Count;
        }
    }
}
