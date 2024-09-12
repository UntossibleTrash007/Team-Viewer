using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoApp
{
    internal class Node<T>
    {
        public T Item { get; set; }

        public Node<T>? Next { get; internal set; }
        public Node<T>? Prev { get; internal set; }

        public Node(T item)
        {
            Item = item;
        }
    }
}
