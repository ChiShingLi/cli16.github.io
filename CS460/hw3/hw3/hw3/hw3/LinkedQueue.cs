using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw3
{
    class LinkedQueue<T> : QueueInterface
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }

        public T push(T element)
        {
            if (element == null)
            {
                throw new System.ArgumentNullException();
            }

            if (isEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                rear = front = tmp;
            }
            else
            {
                ///general case
                Node<T> tmp = new Node<T>(element, null);
                rear.next = tmp;
                rear = tmp;
            }
            return element;
        }

        public T pop()
        {
            T tmp;
            if (isEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when pop was invoked.");
            }
            else if (front == rear)
            {
                ///if one item in queue
                tmp = front.data;
                front = null;
                rear = null;
            }
            else
            {
                ///general case
                tmp = front.data;
                front = front.next;
            }
            return tmp;
        }
     

        public bool isEmpty()
        {
            if (front == null && rear == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
