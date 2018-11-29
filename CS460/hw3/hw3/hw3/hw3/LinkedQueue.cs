using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw3
{
    ///<summary>
    /// A Singly Linked FIFO Queue.  
    /// From Dale, Joyce and Weems "Object-Oriented Data Structures Using Java"
    /// Modified for CS 460 HW3
    /// 
    /// See QueueInterface.java for documentation
    ///</summary>

    class LinkedQueue<T> : QueueInterface
    {
        private Node<T> front;
        private Node<T> rear;

        public LinkedQueue()
        {
            front = null;
            rear = null;
        }

        public T Push(T element)
        {
            if (element == null)
            {
                throw new System.ArgumentNullException();
            }

            if (IsEmpty())
            {
                Node<T> tmp = new Node<T>(element, null);
                rear = front = tmp;
            }
            else
            {
                ///general case
                Node<T> tmp = new Node<T>(element, null);
                rear.Next = tmp;
                rear = tmp;
            }
            return element;
        }

        public T Pop()
        {
            T tmp;
            if (IsEmpty())
            {
                throw new QueueUnderflowException("The queue was empty when Pop was invoked.");
            }
            else if (front == rear)
            {
                ///if one item in queue
                tmp = front.Data;
                front = null;
                rear = null;
            }
            else
            {
                ///general case
                tmp = front.Data;
                front = front.Next;
            }
            return tmp;
        }


        public bool IsEmpty()
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
