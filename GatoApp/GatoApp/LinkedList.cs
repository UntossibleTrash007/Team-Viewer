using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoApp
{
    internal class LinkedList<T> : IEnumerable<T>
    {
        public Node<T>? head { get; protected set; }
        public Node<T>? tail { get; protected set; }
        public int length = 10;

        public int Count;

        //LL constructor
        public LinkedList()
        {
            head = null;
            tail = null;
        }

        //IEnumerable implementation

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); // Call the <T> version

        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? curr = head;
            while (curr != null)
            {
                yield return curr.Item;
                curr = curr.Next;
            }
        }


        //AddFirst(): add an element to the front of the list.
        //Note for me: you don't have to itterate through the list to move elements down it does that for you lmaoo
        public void AddFirst(Node<T> Item)
        {
            Node<T> newHead = Item;
            //Check if the head is null, if it is, newHead becomes the head
            if (head == null)
            {
                head = newHead;
            }
            else
            {
                //if head is not null, move head to position after newhead and set newhead equal to head
                newHead.Next = head;
                head = newHead;
            }
        }

        //AddLast(): adds a value to the end of the linked list
        public void AddBack(Node<T> Item)
        {
            //checks to see if head = null, if it is, set item = head
            if (head == null)
            {
                head = Item;
                Count++;
            }
            else
            {
                //grabs the value of the current node, loops through the list to find the location of the next null space
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                //if a null space is found, insert the item
                current.Next = Item;
                Count++;
            }



        }

        //InsertAfter(): inserts a new node after a given value
        public void InsertAfter(Node<T> node, Node<T> newNode)
        {
            //checks if node.Next is null. If it's not, insert newNode
            if (node.Next == null)
            {
                node.Next = newNode;
                Count++;
                //if node.Next is not null, itterate through the list to make room for the new node
            }
            else if (node.Next != null)
            {
                Node<T> current = node;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                node.Next = newNode;
                Count++;
            }

        }

        //InsertBefore(): insert a new node before a given value
        public void InsertBefore(Node<T> node, Node<T> newNode)
        {
            //node is newNode.Next. newNode.Prev now holds node.Prev
            newNode.Next = node;
            newNode.Prev = node.Prev;

            //if node.Prev is null, insert newNode after node.Prev
            if (node.Prev != null)
            {
                node.Prev.Next = newNode;
            }
            else
            {
                head = newNode;
            }

            node.Prev = newNode;
        }

        //Remove(): removes the given node from the list
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. Nothing to remove.");
                return;
            }
            else if (head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }

        //I genuenly don't know what I did here to make it work. It literally defied all logic that my brain was going through so uhhh it works? I guess???
        public Node<T> Remove(Node<T> node)
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty kekw");
            }

            Node<T> current = head;
            while (current != null && current != node)
            {
                current = current.Next;
            }

            if (current == null)
            {
                throw new InvalidOperationException("Item is not in the list");
            }

            if (current.Prev != null)
            {
                current.Prev.Next = current.Next;
            }
            else
            {
                // Removing head
                head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Prev = current.Prev;
            }

            return head;
        }

        //Merge(): merge two different linked lists together
        public void Merge(LinkedList<T> otherList)
        {
            //if the otherList head is null, return, no merge can be done
            if (otherList.head == null)
            {
                return;
            }

            //if the tail of the current list == null, set the otherList head and tail as the initial list head and tail
            if (tail == null)
            {
                head = otherList.head;
                tail = otherList.tail;
                //otherwise, our tail.next = the head of our otherList,set tail equal to the last value in the otherList
            }
            else
            {
                tail.Next = otherList.head;
                otherList.head.Prev = tail;
                tail = otherList.tail;
            }
            //empty the otherList
            otherList.head = null;
            otherList.tail = null;
        }

        //Find(): Find the given value in the list
        public Node<T>? Find(T item)
        {
            //get the value of the current node
            Node<T> current = head;
            //itterate through the list to find the item
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    return current;
                }
                //continue through the list if the item does not equal current
                current = current.Next;
            }
            //if it's not found, return null.
            return null;
        }


    }
}
