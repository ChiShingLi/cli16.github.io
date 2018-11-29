using System;


namespace hw3
{
    /// <summary>
    /// Singly linked node class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node<T> next;
        public Node<T> Next
        {
            set { next = value; }
            get { return next; }
        }

        public Node(T Data, Node<T> Next)
        {
            this.data = Data;
            this.next = Next;
        }
    }
}
